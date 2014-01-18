using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DBHelpers.Tests
{
    [TestFixture]
    public class DbHelperOverloadTests : BaseOverloadTests
    {
        protected override IEnumerable<string> GetRequiredInstanceSignatures()
        {
            return new string[] {
                "Int32 ExecuteNonQuery(DbCommand)",
                "Int32 ExecuteNonQuery(DbCommand, DbConnection)",

                "T ExecuteScalar(DbCommand)",
                "T ExecuteScalar(DbCommand, DbConnection)",

                "T ExecuteScalar(DbCommand, Converter<Object, T>)",
                "T ExecuteScalar(DbCommand, Converter<Object, T>, DbConnection)",

                "DbDataReader ExecuteReader(DbCommand)",
                "DbDataReader ExecuteReader(DbCommand, DbConnection)",

                "DataTable ExecuteDataTable(DbCommand)",
                "DataTable ExecuteDataTable(DbCommand, DbConnection)",
                "DataTable ExecuteDataTable(DbCommand, Int32, Int32)",
                "DataTable ExecuteDataTable(DbCommand, Int32, Int32, DbConnection)",

                "DataSet ExecuteDataSet(DbCommand)",
                "DataSet ExecuteDataSet(DbCommand, DbConnection)",

                "T[] ExecuteArray(DbCommand)",
                "T[] ExecuteArray(DbCommand, DbConnection)",
                "T[] ExecuteArray(DbCommand, Int32, Int32)",
                "T[] ExecuteArray(DbCommand, Int32, Int32, DbConnection)",

                "T[] ExecuteArray(DbCommand, Converter<Object, T>)",
                "T[] ExecuteArray(DbCommand, Converter<Object, T>, DbConnection)",
                "T[] ExecuteArray(DbCommand, Converter<Object, T>, Int32, Int32)",
                "T[] ExecuteArray(DbCommand, Converter<Object, T>, Int32, Int32, DbConnection)",

                "Dictionary<TKey, TValue> ExecuteDictionary(DbCommand)",
                "Dictionary<TKey, TValue> ExecuteDictionary(DbCommand, DbConnection)",
                "Dictionary<TKey, TValue> ExecuteDictionary(DbCommand, Int32, Int32)",
                "Dictionary<TKey, TValue> ExecuteDictionary(DbCommand, Int32, Int32, DbConnection)",

                "Dictionary<TKey, TValue> ExecuteDictionary(DbCommand, Converter<Object, TKey>, Converter<Object, TValue>)",
                "Dictionary<TKey, TValue> ExecuteDictionary(DbCommand, Converter<Object, TKey>, Converter<Object, TValue>, DbConnection)",
                "Dictionary<TKey, TValue> ExecuteDictionary(DbCommand, Converter<Object, TKey>, Converter<Object, TValue>, Int32, Int32)",
                "Dictionary<TKey, TValue> ExecuteDictionary(DbCommand, Converter<Object, TKey>, Converter<Object, TValue>, Int32, Int32, DbConnection)",

                "T ExecuteObject(DbCommand)",
                "T ExecuteObject(DbCommand, DbConnection)",

                "T ExecuteObject(DbCommand, Converter<DbDataReader, T>)",
                "T ExecuteObject(DbCommand, Converter<DbDataReader, T>, DbConnection)",

                "List<T> ExecuteList(DbCommand)",
                "List<T> ExecuteList(DbCommand, DbConnection)",
                "List<T> ExecuteList(DbCommand, Int32, Int32)",
                "List<T> ExecuteList(DbCommand, Int32, Int32, DbConnection)",

                "List<T> ExecuteList(DbCommand, Converter<DbDataReader, T>)",
                "List<T> ExecuteList(DbCommand, Converter<DbDataReader, T>, DbConnection)",
                "List<T> ExecuteList(DbCommand, Converter<DbDataReader, T>, Int32, Int32)",
                "List<T> ExecuteList(DbCommand, Converter<DbDataReader, T>, Int32, Int32, DbConnection)",
                
                "Int32 ExecuteNonQuery(String)",

                "T ExecuteScalar(String)",
                "T ExecuteScalar(String, Converter<Object, T>)",

                "DbDataReader ExecuteReader(String)",

                "DataTable ExecuteDataTable(String)",
                "DataTable ExecuteDataTable(String, Int32, Int32)",

                "DataSet ExecuteDataSet(String)",

                "T[] ExecuteArray(String)",
                "T[] ExecuteArray(String, Int32, Int32)",

                "T[] ExecuteArray(String, Converter<Object, T>)",
                "T[] ExecuteArray(String, Converter<Object, T>, Int32, Int32)",

                "Dictionary<TKey, TValue> ExecuteDictionary(String)",
                "Dictionary<TKey, TValue> ExecuteDictionary(String, Int32, Int32)",

                "Dictionary<TKey, TValue> ExecuteDictionary(String, Converter<Object, TKey>, Converter<Object, TValue>)",
                "Dictionary<TKey, TValue> ExecuteDictionary(String, Converter<Object, TKey>, Converter<Object, TValue>, Int32, Int32)",

                "T ExecuteObject(String)",
                "T ExecuteObject(String, Converter<DbDataReader, T>)",

                "List<T> ExecuteList(String)",
                "List<T> ExecuteList(String, Int32, Int32)",

                "List<T> ExecuteList(String, Converter<DbDataReader, T>)",
                "List<T> ExecuteList(String, Converter<DbDataReader, T>, Int32, Int32)",
            };
        }

        protected override IEnumerable<string> GetExistingInstanceSignatures()
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

            var type = typeof(DBHelper);

            foreach (var method in methods)
                foreach (var signature in type.GetSignatures(method, BindingFlags.Public | BindingFlags.Instance))
                    yield return signature;
        }
    }
}
