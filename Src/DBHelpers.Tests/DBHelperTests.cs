using Moq;
using Moq.Protected;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace DBHelpers.Tests
{
    [TestFixture]
    public class DBHelperTests
    {
        private InternalDBHelper DB = new InternalDBHelper();

        [Test]
        public void CreateCommand_NoParameters()
        {
            var db = NewSqlHelper();

            var commandText = "select * from table";
            var command = db.CreateCommand(commandText);

            Assert.AreEqual(commandText, command.CommandText);
            Assert.AreEqual(CommandType.Text, command.CommandType);
            Assert.AreEqual(0, command.Parameters.Count);
        }

        [Test]
        public void CreateCommand_WithParameters()
        {
            var db = NewSqlHelper();

            var commandText = "text {0}, {1}, {2}, {3}";
            var p0 = 1;
            var p1 = "foo";
            var p2 = DateTime.Now;
            var p3 = new RawValue("(raw text)");
            var command = db.CreateCommand(commandText, p0, p1, p2, p3);

            Assert.AreEqual("text @p0, @p1, @p2, (raw text)", command.CommandText);
            Assert.AreEqual(CommandType.Text, command.CommandType);
            Assert.AreEqual(3, command.Parameters.Count);
            Assert.AreEqual(p0, command.Parameters[0].Value);
            Assert.AreEqual(p1, command.Parameters[1].Value);
            Assert.AreEqual(p2, command.Parameters[2].Value);
        }

        [Test]
        public void CreateParameterName()
        {
            var param = DB.CreateParameterName_(123);
            Assert.AreEqual("$p123", param);
        }

        [Test]
        public void ExecuteArray()
        {
            var command = DB.Factory.CreateCommand();
            var arr = DB.ExecuteArray<int>(command);

            Assert.AreEqual(50, arr.Length);
        }

        [Test]
        public void ExecuteDataSet()
        {
            var adapter = new Mock<DbDataAdapter>();
            var factory = new MockProviderFactory() { NewDataAdapter = () => adapter.Object };

            adapter.Setup(a => a.Fill(It.IsAny<DataSet>()));
            var db = new DBHelper(factory, "cn");

            var command = db.Factory.CreateCommand();
            db.ExecuteDataSet(command);

            adapter.VerifyAll();
        }

        [Test]
        public void ExecuteDataTable()
        {
            Assert.Inconclusive("No simple way to check for DbDataAdapter.Fill(DataTable).");
        }

        [Test]
        public void ExecuteDictionary()
        {
            var command = DB.Factory.CreateCommand();
            var dict = DB.ExecuteDictionary<int, string>(command);

            Assert.AreEqual(50, dict.Count);
        }

        [Test]
        public void ExecuteList()
        {
            var command = DB.Factory.CreateCommand();
            var list = DB.ExecuteList<MockProviderFactory.DataReaderModel>(command);

            Assert.IsNotNull(list);
            Assert.AreEqual(50, list.Count);
        }

        [Test]
        public void ExecuteNonQuery()
        {
            var mockCommand = new Mock<DbCommand>();

            mockCommand.SetupSet(c => c.Connection = It.IsAny<DbConnection>());
            mockCommand.Setup(c => c.ExecuteNonQuery());

            DB.ExecuteNonQuery(mockCommand.Object);

            mockCommand.VerifyAll();
        }

        [Test]
        public void ExecuteObject()
        {
            var command = DB.Factory.CreateCommand();
            var obj = DB.ExecuteObject<MockProviderFactory.DataReaderModel>(command);

            Assert.IsNotNull(obj);
            Assert.AreEqual(0, obj.IntCol);
            Assert.AreEqual("row 0", obj.StringCol);
            Assert.AreEqual(DateTime.Today, obj.DateCol);
        }

        [Test]
        public void ExecuteReader()
        {
            var mockConnection = new Mock<DbConnection>();
            var mockCommand = new Mock<DbCommand>();

            mockCommand.SetupSet(c => c.Connection = It.IsAny<DbConnection>());
            mockCommand.Protected().Setup("ExecuteDbDataReader", CommandBehavior.CloseConnection);

            var reader = DB.ExecuteReader(mockCommand.Object, mockConnection.Object);

            mockCommand.VerifyAll();
        }

        [Test]
        public void ExecuteScalar()
        {
            var mockCommand = new Mock<DbCommand>();
            var expectedValue = 10;

            mockCommand.SetupSet(c => c.Connection = It.IsAny<DbConnection>());
            mockCommand.Setup(c => c.ExecuteScalar()).Returns(expectedValue);

            var value = DB.ExecuteScalar<int>(mockCommand.Object);

            mockCommand.VerifyAll();
            Assert.AreEqual(expectedValue, value);
        }

        [TestCaseSource("FillFromReaderSource")]
        public void FillFromReader(int startRecord, int maxRecords, int expectedCount, int firstValue)
        {
            var factory = (MockProviderFactory)DB.Factory;
            var reader = factory.CreateReader();

            var list = new List<int>();

            DB.FillFromReader_(reader, startRecord, maxRecords, r => list.Add(r.GetInt32(0)));

            Assert.AreEqual(expectedCount, list.Count, "Invalid row count.");

            if (list.Count > 0)
                Assert.AreEqual(firstValue, list[0], "Invalid first value.");
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FillFromReader(int startRecord, int maxRecords)
        {
            var factory = (MockProviderFactory)DB.Factory;
            var reader = factory.CreateReader();

            DB.FillFromReader_(reader, startRecord, maxRecords, r => { });
        }

        public IEnumerable<TestCaseData> FillFromReaderSource()
        {
            var dataSets = new[]
            {
                new [] {0, 0, 0, 0},
                new [] {0, -1, 50, 0},
                new [] {51, 10, 0, 0},
                new [] {0, 100, 50, 0},
                new [] {10, 20, 20, 10},
                new [] {45, 10, 5, 45}
            };

            foreach (var arr in dataSets)
            {
                string name = String.Format("Start {0}, maxRecords {1} should return {2}", arr[0], arr[1], arr[2]);

                int expectedCount = arr[2];

                if (expectedCount > 0)
                    name += " with first index " + arr[3];

                yield return new TestCaseData(arr[0], arr[1], arr[2], arr[3]).SetName(name);
            }
        }

        private InternalDBHelper NewMockHelper()
        {
            return new InternalDBHelper();
        }

        private DBHelper NewSqlHelper()
        {
            return new DBHelper(SqlClientFactory.Instance, "cn");
        }
    }
}
