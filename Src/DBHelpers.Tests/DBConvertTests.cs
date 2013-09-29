using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DBHelpers.Tests
{
    [TestFixture]
    public class DBConvertTests
    {
        [TestCaseSource("NumericConversionCases")]
        public void ConvertTo_NumericsFromNumericsInRange_ReturnsCastValue(Type targetType, object sourceValue)
        {
            var value = DBConvert.To(targetType, sourceValue);
            Assert.IsInstanceOf(targetType, value);
        }

        [TestCaseSource("NumericTypes")]
        [TestCaseSource("NonNumericTypes")]
        public void ConvertTo_FromNull_ReturnsDefaultValue(Type targetType)
        {
            object reference = targetType.IsValueType ? Activator.CreateInstance(targetType) : null;
            object value = DBConvert.To(targetType, (object)null);
            Assert.AreEqual(reference, value);
        }

        [TestCaseSource("NumericTypes")]
        [TestCaseSource("NonNumericTypes")]
        public void ConvertTo_FromDBNull_ReturnsDefaultValue(Type targetType)
        {
            object reference = targetType.IsValueType ? Activator.CreateInstance(targetType) : null;
            object value = DBConvert.To(targetType, DBNull.Value);
            Assert.AreEqual(reference, value);
        }
        
        [TestCaseSource("NumericValues")]
        [TestCaseSource("NonNumericValues")]
        public void ConvertTo_String_ReturnsNonEmptyValue(object value)
        {
            string s = DBConvert.To<string>(value);
            Assert.IsNotEmpty(s);
        }

        [TestCase('A')]
        [TestCase("A")]
        [TestCase("ABC")]
        public void ConvertTo_Char_ReturnsCharOrFirstChar(object value)
        {
            var c = DBConvert.To<char>(value);
            Assert.AreEqual('A', c);
        }

        [TestCase("2000-12-31T23:59:59")]
        [TestCase("2000-12-31 23:59:59")]
        public void ConvertTo_DateTime_ReturnsDateTime(object value)
        {
            var reference = new DateTime(2000, 12, 31, 23, 59, 59);
            var dt = DBConvert.To<DateTime>(value);
            Assert.AreEqual(reference, dt);
        }

        [TestCase("2000-12-31")]
        public void ConvertTo_DateTime_ReturnsDate(object value)
        {
            var reference = new DateTime(2000, 12, 31);
            var dt = DBConvert.To<DateTime>(value);
            Assert.AreEqual(reference, dt);
        }

        [TestCase("5033b416-9f63-4370-a435-1c0c7c102e67")]
        [TestCase("5033b4169f634370a4351c0c7c102e67")]
        public void ConvertTo_Guid_ReturnsGuid(object value)
        {
            var reference = Guid.Parse("5033b416-9f63-4370-a435-1c0c7c102e67");
            var guid = DBConvert.To<Guid>(value);

            Assert.AreEqual(reference, guid);
        }

        [TestCase(true)]
        [TestCase("true")]
        [TestCase("TRUE")]
        [TestCase(1)]
        [TestCase('1')]
        [TestCase("1")]
        public void ConvertTo_Bool_ReturnsTrue(object value)
        {
            var b = DBConvert.To<bool>(value);
            Assert.AreEqual(true, b);
        }

        [TestCase(false)]
        [TestCase("false")]
        [TestCase("FALSE")]
        [TestCase(0)]
        [TestCase('0')]
        [TestCase("0")]
        public void ConvertTo_Bool_ReturnsFalse(object value)
        {
            var b = DBConvert.To<bool>(value);
            Assert.AreEqual(false, b);
        }

        private Type[] NumericTypes = {
            typeof(SByte),
            typeof(Int16),
            typeof(Int32),
            typeof(Int64),
            typeof(Byte),
            typeof(UInt16),
            typeof(UInt32),
            typeof(UInt64),
            typeof(Decimal),
            typeof(Single),
            typeof(Double)
        };

        private Type[] NonNumericTypes = {
            typeof(char),
            typeof(string),
            typeof(DateTime),
            typeof(Guid),
            typeof(bool)
        };

        // numeric types used by data providers
        private object[] NumericValues = {
            (SByte) 127,
            (Int16) 127,
            (Int32) 127,
            (Int64) 127,
            (Byte) 127,
            (UInt16) 127,
            (UInt32) 127,
            (UInt64) 127,
            (Decimal) 127,
            (Single) 127,
            (Double) 127
        };

        // core non-numeric types used by data providers
        private object[] NonNumericValues = {
            "string",
            'c',
            DateTime.Today,
            Guid.Parse("5033b416-9f63-4370-a435-1c0c7c102e67"),
            true
        };

        private IEnumerable<TestCaseData> NumericConversionCases()
        {
            foreach (var type in NumericTypes)
            {
                foreach (var value in NumericValues)
                {
                    var name = String.Format("{0} to {1}", value.GetType().Name, type.Name);
                    yield return new TestCaseData(type, value).SetName(name);
                }
            }
        }
    }
}
