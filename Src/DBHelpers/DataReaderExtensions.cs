using System;
using System.Data.Common;
using System.Globalization;

namespace DBHelpers
{
    public static class DataReaderExtensions
    {
        public static T Get<T>(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.To<T>(reader[ordinal], provider);
        }

        public static T Get<T>(this DbDataReader reader, int ordinal)
        {
            return DBConvert.To<T>(reader[ordinal], CultureInfo.CurrentCulture);
        }

        public static T Get<T>(this DbDataReader reader, string name, IFormatProvider provider)
        {
            return DBConvert.To<T>(reader[name], provider);
        }

        public static T Get<T>(this DbDataReader reader, string name)
        {
            return DBConvert.To<T>(reader[name], CultureInfo.CurrentCulture);
        }
    }
}
