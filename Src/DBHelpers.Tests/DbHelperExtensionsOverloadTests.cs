using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DBHelpers.Tests
{
    [TestFixture]
    public class DbHelperExtensionsOverloadTests : BaseOverloadTests
    {
        protected override IEnumerable<string> GetRequiredStaticSignatures()
        {
            return new string[] {
                "Int32 ExecuteNonQuery(DBHelper, String)",

                "T ExecuteScalar(DBHelper, String)",
                "T ExecuteScalar(DBHelper, String, Converter<Object, T>)",

                "DbDataReader ExecuteReader(DBHelper, String)",

                "DataTable ExecuteDataTable(DBHelper, String)",
                "DataTable ExecuteDataTable(DBHelper, String, Int32, Int32)",

                "DataSet ExecuteDataSet(DBHelper, String)",

                "T[] ExecuteArray(DBHelper, String)",
                "T[] ExecuteArray(DBHelper, String, Int32, Int32)",

                "T[] ExecuteArray(DBHelper, String, Converter<Object, T>)",
                "T[] ExecuteArray(DBHelper, String, Converter<Object, T>, Int32, Int32)",

                "Dictionary<TKey, TValue> ExecuteDictionary(DBHelper, String)",
                "Dictionary<TKey, TValue> ExecuteDictionary(DBHelper, String, Int32, Int32)",

                "Dictionary<TKey, TValue> ExecuteDictionary(DBHelper, String, Converter<Object, TKey>, Converter<Object, TValue>)",
                "Dictionary<TKey, TValue> ExecuteDictionary(DBHelper, String, Converter<Object, TKey>, Converter<Object, TValue>, Int32, Int32)",

                "T ExecuteObject(DBHelper, String)",
                "T ExecuteObject(DBHelper, String, Converter<DbDataReader, T>)",

                "List<T> ExecuteList(DBHelper, String)",
                "List<T> ExecuteList(DBHelper, String, Int32, Int32)",

                "List<T> ExecuteList(DBHelper, String, Converter<DbDataReader, T>)",
                "List<T> ExecuteList(DBHelper, String, Converter<DbDataReader, T>, Int32, Int32)"
            };
        }

        protected override IEnumerable<string> GetExistingStaticSignatures()
        {
            string[] methods = {
                "ExecuteNonQuery",
                "ExecuteScalar",
                "ExecuteReader",
                "ExecuteDataTable",
                "ExecuteDataSet",
                "ExecuteArray",
                "ExecuteDictionary",
                "ExecuteObject",
                "ExecuteList"
            };

            var type = typeof(DBHelperExtensions);

            foreach (var method in methods)
                foreach (var signature in type.GetSignatures(method, BindingFlags.Public | BindingFlags.Static))
                    yield return signature;
        }
    }
}
