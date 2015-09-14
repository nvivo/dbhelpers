using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace DBHelpers.Tests
{
    [TestFixture]
    public class DbHelperOverloadTests : BaseOverloadTests
    {
        protected override IEnumerable<string> GetRequiredInstanceSignatures()
        {
            var sigs = new string[] {
                "Int32 ExecuteNonQuery(DbCommand)",
                "Int32 ExecuteNonQuery(DbCommand, DbConnection)",
                "Int32 ExecuteNonQuery(DbCommand, DbTransaction)",

                "T ExecuteScalar(DbCommand)",
                "T ExecuteScalar(DbCommand, DbConnection)",
                "T ExecuteScalar(DbCommand, DbTransaction)",

                "T ExecuteScalar(DbCommand, Converter<Object, T>)",
                "T ExecuteScalar(DbCommand, Converter<Object, T>, DbConnection)",
                "T ExecuteScalar(DbCommand, Converter<Object, T>, DbTransaction)",

                "DbDataReader ExecuteReader(DbCommand)",
                "DbDataReader ExecuteReader(DbCommand, DbConnection)",
                "DbDataReader ExecuteReader(DbCommand, DbTransaction)",

                "DataTable ExecuteDataTable(DbCommand)",
                "DataTable ExecuteDataTable(DbCommand, DbConnection)",
                "DataTable ExecuteDataTable(DbCommand, DbTransaction)",
                "DataTable ExecuteDataTable(DbCommand, Int32, Int32)",
                "DataTable ExecuteDataTable(DbCommand, Int32, Int32, DbConnection)",
                "DataTable ExecuteDataTable(DbCommand, Int32, Int32, DbTransaction)",

                "DataSet ExecuteDataSet(DbCommand)",
                "DataSet ExecuteDataSet(DbCommand, DbConnection)",
                "DataSet ExecuteDataSet(DbCommand, DbTransaction)",

                "T[] ExecuteArray(DbCommand)",
                "T[] ExecuteArray(DbCommand, DbConnection)",
                "T[] ExecuteArray(DbCommand, DbTransaction)",
                "T[] ExecuteArray(DbCommand, Int32, Int32)",
                "T[] ExecuteArray(DbCommand, Int32, Int32, DbConnection)",
                "T[] ExecuteArray(DbCommand, Int32, Int32, DbTransaction)",

                "T[] ExecuteArray(DbCommand, Converter<Object, T>)",
                "T[] ExecuteArray(DbCommand, Converter<Object, T>, DbConnection)",
                "T[] ExecuteArray(DbCommand, Converter<Object, T>, DbTransaction)",
                "T[] ExecuteArray(DbCommand, Converter<Object, T>, Int32, Int32)",
                "T[] ExecuteArray(DbCommand, Converter<Object, T>, Int32, Int32, DbConnection)",
                "T[] ExecuteArray(DbCommand, Converter<Object, T>, Int32, Int32, DbTransaction)",

                "Dictionary<TKey, TValue> ExecuteDictionary(DbCommand)",
                "Dictionary<TKey, TValue> ExecuteDictionary(DbCommand, DbConnection)",
                "Dictionary<TKey, TValue> ExecuteDictionary(DbCommand, DbTransaction)",
                "Dictionary<TKey, TValue> ExecuteDictionary(DbCommand, Int32, Int32)",
                "Dictionary<TKey, TValue> ExecuteDictionary(DbCommand, Int32, Int32, DbConnection)",
                "Dictionary<TKey, TValue> ExecuteDictionary(DbCommand, Int32, Int32, DbTransaction)",

                "Dictionary<TKey, TValue> ExecuteDictionary(DbCommand, Converter<Object, TKey>, Converter<Object, TValue>)",
                "Dictionary<TKey, TValue> ExecuteDictionary(DbCommand, Converter<Object, TKey>, Converter<Object, TValue>, DbConnection)",
                "Dictionary<TKey, TValue> ExecuteDictionary(DbCommand, Converter<Object, TKey>, Converter<Object, TValue>, DbTransaction)",
                "Dictionary<TKey, TValue> ExecuteDictionary(DbCommand, Converter<Object, TKey>, Converter<Object, TValue>, Int32, Int32)",
                "Dictionary<TKey, TValue> ExecuteDictionary(DbCommand, Converter<Object, TKey>, Converter<Object, TValue>, Int32, Int32, DbConnection)",
                "Dictionary<TKey, TValue> ExecuteDictionary(DbCommand, Converter<Object, TKey>, Converter<Object, TValue>, Int32, Int32, DbTransaction)",

                "T ExecuteObject(DbCommand)",
                "T ExecuteObject(DbCommand, DbConnection)",
                "T ExecuteObject(DbCommand, DbTransaction)",

                "T ExecuteObject(DbCommand, Converter<DbDataReader, T>)",
                "T ExecuteObject(DbCommand, Converter<DbDataReader, T>, DbConnection)",
                "T ExecuteObject(DbCommand, Converter<DbDataReader, T>, DbTransaction)",

                "List<T> ExecuteList(DbCommand)",
                "List<T> ExecuteList(DbCommand, DbConnection)",
                "List<T> ExecuteList(DbCommand, DbTransaction)",
                "List<T> ExecuteList(DbCommand, Int32, Int32)",
                "List<T> ExecuteList(DbCommand, Int32, Int32, DbConnection)",
                "List<T> ExecuteList(DbCommand, Int32, Int32, DbTransaction)",

                "List<T> ExecuteList(DbCommand, Converter<DbDataReader, T>)",
                "List<T> ExecuteList(DbCommand, Converter<DbDataReader, T>, DbConnection)",
                "List<T> ExecuteList(DbCommand, Converter<DbDataReader, T>, DbTransaction)",
                "List<T> ExecuteList(DbCommand, Converter<DbDataReader, T>, Int32, Int32)",
                "List<T> ExecuteList(DbCommand, Converter<DbDataReader, T>, Int32, Int32, DbConnection)",
                "List<T> ExecuteList(DbCommand, Converter<DbDataReader, T>, Int32, Int32, DbTransaction)",

                "Int32 ExecuteNonQuery(String)",
                "Int32 ExecuteNonQuery(String, DbConnection)",
                "Int32 ExecuteNonQuery(String, DbTransaction)",

                "T ExecuteScalar(String)",
                "T ExecuteScalar(String, DbConnection)",
                "T ExecuteScalar(String, DbTransaction)",
                "T ExecuteScalar(String, Converter<Object, T>)",
                "T ExecuteScalar(String, Converter<Object, T>, DbConnection)",
                "T ExecuteScalar(String, Converter<Object, T>, DbTransaction)",

                "DbDataReader ExecuteReader(String)",
                "DbDataReader ExecuteReader(String, DbConnection)",
                "DbDataReader ExecuteReader(String, DbTransaction)",

                "DataTable ExecuteDataTable(String)",
                "DataTable ExecuteDataTable(String, DbConnection)",
                "DataTable ExecuteDataTable(String, DbTransaction)",
                "DataTable ExecuteDataTable(String, Int32, Int32)",
                "DataTable ExecuteDataTable(String, Int32, Int32, DbConnection)",
                "DataTable ExecuteDataTable(String, Int32, Int32, DbTransaction)",

                "DataSet ExecuteDataSet(String)",
                "DataSet ExecuteDataSet(String, DbConnection)",
                "DataSet ExecuteDataSet(String, DbTransaction)",

                "T[] ExecuteArray(String)",
                "T[] ExecuteArray(String, DbConnection)",
                "T[] ExecuteArray(String, DbTransaction)",
                "T[] ExecuteArray(String, Int32, Int32)",
                "T[] ExecuteArray(String, Int32, Int32, DbConnection)",
                "T[] ExecuteArray(String, Int32, Int32, DbTransaction)",

                "T[] ExecuteArray(String, Converter<Object, T>)",
                "T[] ExecuteArray(String, Converter<Object, T>, DbConnection)",
                "T[] ExecuteArray(String, Converter<Object, T>, DbTransaction)",
                "T[] ExecuteArray(String, Converter<Object, T>, Int32, Int32)",
                "T[] ExecuteArray(String, Converter<Object, T>, Int32, Int32, DbConnection)",
                "T[] ExecuteArray(String, Converter<Object, T>, Int32, Int32, DbTransaction)",

                "Dictionary<TKey, TValue> ExecuteDictionary(String)",
                "Dictionary<TKey, TValue> ExecuteDictionary(String, DbConnection)",
                "Dictionary<TKey, TValue> ExecuteDictionary(String, DbTransaction)",
                "Dictionary<TKey, TValue> ExecuteDictionary(String, Int32, Int32)",
                "Dictionary<TKey, TValue> ExecuteDictionary(String, Int32, Int32, DbConnection)",
                "Dictionary<TKey, TValue> ExecuteDictionary(String, Int32, Int32, DbTransaction)",

                "Dictionary<TKey, TValue> ExecuteDictionary(String, Converter<Object, TKey>, Converter<Object, TValue>)",
                "Dictionary<TKey, TValue> ExecuteDictionary(String, Converter<Object, TKey>, Converter<Object, TValue>, DbConnection)",
                "Dictionary<TKey, TValue> ExecuteDictionary(String, Converter<Object, TKey>, Converter<Object, TValue>, DbTransaction)",
                "Dictionary<TKey, TValue> ExecuteDictionary(String, Converter<Object, TKey>, Converter<Object, TValue>, Int32, Int32)",
                "Dictionary<TKey, TValue> ExecuteDictionary(String, Converter<Object, TKey>, Converter<Object, TValue>, Int32, Int32, DbConnection)",
                "Dictionary<TKey, TValue> ExecuteDictionary(String, Converter<Object, TKey>, Converter<Object, TValue>, Int32, Int32, DbTransaction)",

                "T ExecuteObject(String)",
                "T ExecuteObject(String, DbConnection)",
                "T ExecuteObject(String, DbTransaction)",
                "T ExecuteObject(String, Converter<DbDataReader, T>)",
                "T ExecuteObject(String, Converter<DbDataReader, T>, DbConnection)",
                "T ExecuteObject(String, Converter<DbDataReader, T>, DbTransaction)",

                "List<T> ExecuteList(String)",
                "List<T> ExecuteList(String, DbConnection)",
                "List<T> ExecuteList(String, DbTransaction)",
                "List<T> ExecuteList(String, Int32, Int32)",
                "List<T> ExecuteList(String, Int32, Int32, DbConnection)",
                "List<T> ExecuteList(String, Int32, Int32, DbTransaction)",

                "List<T> ExecuteList(String, Converter<DbDataReader, T>)",
                "List<T> ExecuteList(String, Converter<DbDataReader, T>, DbConnection)",
                "List<T> ExecuteList(String, Converter<DbDataReader, T>, DbTransaction)",
                "List<T> ExecuteList(String, Converter<DbDataReader, T>, Int32, Int32)",
                "List<T> ExecuteList(String, Converter<DbDataReader, T>, Int32, Int32, DbConnection)",
                "List<T> ExecuteList(String, Converter<DbDataReader, T>, Int32, Int32, DbTransaction)",
            };

            // hack to create an async version of all overloads above

            var asyncSigs = new List<string>();
            var matcher = new Regex(@"(.+) (.+)\((.+)\)");

            foreach (var sig in sigs)
            {
                var asyncSig = matcher.Replace(sig, m => String.Format("Task<{0}> {1}Async({2})", m.Groups[1].Value, m.Groups[2].Value, m.Groups[3].Value));
                asyncSigs.Add(asyncSig);
            }

            return sigs.Concat(asyncSigs);
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
            {
                foreach (var signature in type.GetSignatures(method, BindingFlags.Public | BindingFlags.Instance))
                    yield return signature;

                foreach (var signature in type.GetSignatures(method + "Async", BindingFlags.Public | BindingFlags.Instance))
                    yield return signature;
            }
        }
    }
}
