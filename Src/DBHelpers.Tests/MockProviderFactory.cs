using Moq;
using Moq.Protected;
using System;
using System.Data;
using System.Data.Common;

namespace DBHelpers.Tests
{
    public class MockProviderFactory : DbProviderFactory
    {
        public class DataReaderModel
        {
            public DateTime DateCol { get; set; }
            public int IntCol { get; set; }
            public string StringCol { get; set; }
            public string UnmappedCol { get; set; }
        }

        public Func<DbConnection> NewConnection = () => new Mock<DbConnection>().Object;
        public Func<DbParameter> NewParameter = () => new Mock<DbParameter>().Object;
        public Func<DbDataAdapter> NewDataAdapter = () => new Mock<DbDataAdapter>().Object;

        public override DbCommand CreateCommand()
        {
            var command = new Mock<DbCommand>();

            command
                .Protected()
                .Setup<DbDataReader>("ExecuteDbDataReader", ItExpr.IsAny<CommandBehavior>())
                .Returns(() => CreateReader());

            return command.Object;
        }

        public override DbCommandBuilder CreateCommandBuilder()
        {
            var mock = new Mock<DbCommandBuilder>();

            mock.Protected()
                .Setup<string>("GetParameterPlaceholder", ItExpr.IsAny<int>())
                .Returns((int i) => "$p" + i);

            return mock.Object;
        }

        public override DbConnection CreateConnection()
        {
            return NewConnection();
        }

        public override DbDataAdapter CreateDataAdapter()
        {
            return NewDataAdapter();
        }

        public override DbParameter CreateParameter()
        {
            return NewParameter();
        }

        public DbDataReader CreateReader()
        {
            var dt = new DataTable();
            dt.Columns.Add("IntCol", typeof(int));
            dt.Columns.Add("StringCol", typeof(string));
            dt.Columns.Add("DateCol", typeof(DateTime));

            for (int i = 0; i < 50; i++)
                dt.Rows.Add(i, "row " + i, DateTime.Today.AddDays(i));

            return dt.CreateDataReader();
        }
    }
}
