using System;
using System.Data.Common;

namespace DBHelpers.Tests
{
    public class InternalDBHelper : DBHelper
    {
        public InternalDBHelper()
            : base(new MockProviderFactory(), "fake connection string")
        { }

        public string CreateParameterName_(int index)
        {
            return base.CreateParameterName(index);
        }

        public void FillFromReader_(DbDataReader reader, int startRecord, int maxRecords, Action<DbDataReader> action)
        {
            FillFromReader(reader, startRecord, maxRecords, action);
        }

        protected override void OnExecuteCommand(DbCommand command)
        {
            OnExecuteCommand_(command);
        }

        public void OnExecuteCommand_(DbCommand command)
        {
            base.OnExecuteCommand(command);
        }
    }
}
