using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace DBHelpers.Tests
{
    [TestFixture]
    public class DbHelperExtensionsOverloadTests
    {
        private string[] RequiredSignatures = {
            "int ExecuteNonQuery(DBHelper, string)",

            "T ExecuteScalar(DBHelper, string)",
            "T ExecuteScalar(DBHelper, string, Converter<object, T>)",

            "DbDataReader ExecuteReader(DBHelper, string)",

            "DataTable ExecuteDataTable(DBHelper, string)",
            "DataTable ExecuteDataTable(DBHelper, string, int, int)",

            "DataSet ExecuteDataSet(DBHelper, string)",

            "T[] ExecuteArray(DBHelper, string)",
            "T[] ExecuteArray(DBHelper, string, int, int)",

            "T[] ExecuteArray(DBHelper, string, Converter<object, T>)",
            "T[] ExecuteArray(DBHelper, string, Converter<object, T>, int, int)",

            "Dictionary<TKey, TValue> ExecuteDictionary(DBHelper, string)",
            "Dictionary<TKey, TValue> ExecuteDictionary(DBHelper, string, int, int)",

            "Dictionary<TKey, TValue> ExecuteDictionary(DBHelper, string, Converter<object, TKey>, Converter<object, TValue>)",
            "Dictionary<TKey, TValue> ExecuteDictionary(DBHelper, string, Converter<object, TKey>, Converter<object, TValue>, int, int)",

            "T ExecuteObject(DBHelper, string)",
            "T ExecuteObject(DBHelper, string, Converter<DbDataReader, T>)",

            "List<T> ExecuteList(DBHelper, string)",
            "List<T> ExecuteList(DBHelper, string, int, int)",

            "List<T> ExecuteList(DBHelper, string, Converter<DbDataReader, T>)",
            "List<T> ExecuteList(DBHelper, string, Converter<DbDataReader, T>, int, int)"
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
                existing.AddRange(typeof(DBHelperExtensions).GetSignatures(methodName, true));

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
                existing.AddRange(typeof(DBHelperExtensions).GetSignatures(methodName, true));

            var notRequired = existing.Except(RequiredSignatures);

            foreach (var signature in notRequired)
                yield return new TestCaseData(false).SetName(signature);

            if (notRequired.Count() == 0)
                yield return new TestCaseData(true).SetName("All Signatures OK");
        }
    }
}
