using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace DBHelpers.Tests
{
    [TestFixture]
    public class DbHelperOverloadTests
    {
        private string[] RequiredSignatures = {
            "int ExecuteNonQuery(DbCommand)",
            "int ExecuteNonQuery(DbCommand, DbConnection)",

            "T ExecuteScalar(DbCommand)",
            "T ExecuteScalar(DbCommand, DbConnection)",

            "T ExecuteScalar(DbCommand, Converter<object, T>)",
            "T ExecuteScalar(DbCommand, Converter<object, T>, DbConnection)",

            "DbDataReader ExecuteReader(DbCommand)",
            "DbDataReader ExecuteReader(DbCommand, DbConnection)",

            "DataTable ExecuteDataTable(DbCommand)",
            "DataTable ExecuteDataTable(DbCommand, DbConnection)",
            "DataTable ExecuteDataTable(DbCommand, int, int)",
            "DataTable ExecuteDataTable(DbCommand, int, int, DbConnection)",

            "DataSet ExecuteDataSet(DbCommand)",
            "DataSet ExecuteDataSet(DbCommand, DbConnection)",

            "T[] ExecuteArray(DbCommand)",
            "T[] ExecuteArray(DbCommand, DbConnection)",
            "T[] ExecuteArray(DbCommand, int, int)",
            "T[] ExecuteArray(DbCommand, int, int, DbConnection)",

            "T[] ExecuteArray(DbCommand, Converter<object, T>)",
            "T[] ExecuteArray(DbCommand, Converter<object, T>, DbConnection)",
            "T[] ExecuteArray(DbCommand, Converter<object, T>, int, int)",
            "T[] ExecuteArray(DbCommand, Converter<object, T>, int, int, DbConnection)",

            "Dictionary<TKey, TValue> ExecuteDictionary(DbCommand)",
            "Dictionary<TKey, TValue> ExecuteDictionary(DbCommand, DbConnection)",
            "Dictionary<TKey, TValue> ExecuteDictionary(DbCommand, int, int)",
            "Dictionary<TKey, TValue> ExecuteDictionary(DbCommand, int, int, DbConnection)",

            "Dictionary<TKey, TValue> ExecuteDictionary(DbCommand, Converter<object, TKey>, Converter<object, TValue>)",
            "Dictionary<TKey, TValue> ExecuteDictionary(DbCommand, Converter<object, TKey>, Converter<object, TValue>, DbConnection)",
            "Dictionary<TKey, TValue> ExecuteDictionary(DbCommand, Converter<object, TKey>, Converter<object, TValue>, int, int)",
            "Dictionary<TKey, TValue> ExecuteDictionary(DbCommand, Converter<object, TKey>, Converter<object, TValue>, int, int, DbConnection)",

            "T ExecuteObject(DbCommand)",
            "T ExecuteObject(DbCommand, DbConnection)",

            "T ExecuteObject(DbCommand, Converter<DbDataReader, T>)",
            "T ExecuteObject(DbCommand, Converter<DbDataReader, T>, DbConnection)",

            "List<T> ExecuteList(DbCommand)",
            "List<T> ExecuteList(DbCommand, DbConnection)",
            "List<T> ExecuteList(DbCommand, int, int)",
            "List<T> ExecuteList(DbCommand, int, int, DbConnection)",

            "List<T> ExecuteList(DbCommand, Converter<DbDataReader, T>)",
            "List<T> ExecuteList(DbCommand, Converter<DbDataReader, T>, DbConnection)",
            "List<T> ExecuteList(DbCommand, Converter<DbDataReader, T>, int, int)",
            "List<T> ExecuteList(DbCommand, Converter<DbDataReader, T>, int, int, DbConnection)"
        };

        private string[] MethodNames = {
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

        [TestCaseSource("SignatureExistTestSource")]
        public void SignatureExists(string signature, string[] existing)
        {
            var exists = existing.Contains(signature);
            Assert.That(exists, "Not Found: " + signature);
        }

        public IEnumerable<TestCaseData> SignatureExistTestSource()
        {
            var existing = new List<string>();

            foreach (var methodName in MethodNames)
                existing.AddRange(typeof(DBHelper).GetSignatures(methodName, false));

            foreach (var signature in RequiredSignatures)
            {
                var testCase = new TestCaseData(signature, existing.ToArray());
                testCase.SetName(signature);

                yield return testCase;
            }
        }

        [TestCaseSource("SignaturesNotInRequiredListTestSource")]
        public void SignaturesNotInRequiredList(bool state)
        {
            Assert.That(state);
        }

        public IEnumerable<TestCaseData> SignaturesNotInRequiredListTestSource()
        {
            var existing = new List<string>();

            foreach (var methodName in MethodNames)
                existing.AddRange(typeof(DBHelper).GetSignatures(methodName, false));

            var notRequired = existing.Except(RequiredSignatures);

            foreach (var signature in notRequired)
                yield return new TestCaseData(false).SetName(signature);

            if (notRequired.Count() == 0)
                yield return new TestCaseData(true).SetName("All Signatures OK");
        }
    }
}
