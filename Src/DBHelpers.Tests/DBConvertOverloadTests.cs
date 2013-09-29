using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DBHelpers.Tests
{
    public class DBConvertOverloadTests : BaseOverloadTests
    {
        protected override IEnumerable<string> GetRequiredStaticSignatures()
        {
            return new string[] {
                "Boolean ToBoolean(Object)",
                "Boolean ToBoolean(Object, IFormatProvider)",

                "SByte ToSByte(Object)",
                "SByte ToSByte(Object, IFormatProvider)",

                "Int16 ToInt16(Object)",
                "Int16 ToInt16(Object, IFormatProvider)",

                "Int32 ToInt32(Object)",
                "Int32 ToInt32(Object, IFormatProvider)",

                "Int64 ToInt64(Object)",
                "Int64 ToInt64(Object, IFormatProvider)",

                "Byte ToByte(Object)",
                "Byte ToByte(Object, IFormatProvider)",

                "UInt16 ToUInt16(Object)",
                "UInt16 ToUInt16(Object, IFormatProvider)",
  
                "UInt32 ToUInt32(Object)",
                "UInt32 ToUInt32(Object, IFormatProvider)",
  
                "UInt64 ToUInt64(Object)",
                "UInt64 ToUInt64(Object, IFormatProvider)",

                "Decimal ToDecimal(Object)",
                "Decimal ToDecimal(Object, IFormatProvider)",

                "Single ToSingle(Object)",
                "Single ToSingle(Object, IFormatProvider)",

                "Double ToDouble(Object)",
                "Double ToDouble(Object, IFormatProvider)",

                "Char ToChar(Object)",
                "Char ToChar(Object, IFormatProvider)",

                "DateTime ToDateTime(Object)",
                "DateTime ToDateTime(Object, IFormatProvider)",

                "Guid ToGuid(Object)",

                "Nullable<Boolean> ToNullableBoolean(Object)",
                "Nullable<Boolean> ToNullableBoolean(Object, IFormatProvider)",

                "Nullable<SByte> ToNullableSByte(Object)",
                "Nullable<SByte> ToNullableSByte(Object, IFormatProvider)",

                "Nullable<Int16> ToNullableInt16(Object)",
                "Nullable<Int16> ToNullableInt16(Object, IFormatProvider)",

                "Nullable<Int32> ToNullableInt32(Object)",
                "Nullable<Int32> ToNullableInt32(Object, IFormatProvider)",

                "Nullable<Int64> ToNullableInt64(Object)",
                "Nullable<Int64> ToNullableInt64(Object, IFormatProvider)",

                "Nullable<Byte> ToNullableByte(Object)",
                "Nullable<Byte> ToNullableByte(Object, IFormatProvider)",

                "Nullable<UInt16> ToNullableUInt16(Object)",
                "Nullable<UInt16> ToNullableUInt16(Object, IFormatProvider)",
  
                "Nullable<UInt32> ToNullableUInt32(Object)",
                "Nullable<UInt32> ToNullableUInt32(Object, IFormatProvider)",
  
                "Nullable<UInt64> ToNullableUInt64(Object)",
                "Nullable<UInt64> ToNullableUInt64(Object, IFormatProvider)",

                "Nullable<Decimal> ToNullableDecimal(Object)",
                "Nullable<Decimal> ToNullableDecimal(Object, IFormatProvider)",

                "Nullable<Single> ToNullableSingle(Object)",
                "Nullable<Single> ToNullableSingle(Object, IFormatProvider)",

                "Nullable<Double> ToNullableDouble(Object)",
                "Nullable<Double> ToNullableDouble(Object, IFormatProvider)",

                "Nullable<Char> ToNullableChar(Object)",
                "Nullable<Char> ToNullableChar(Object, IFormatProvider)",

                "Nullable<DateTime> ToNullableDateTime(Object)",
                "Nullable<DateTime> ToNullableDateTime(Object, IFormatProvider)",				
				
                "Nullable<Guid> ToNullableGuid(Object)",

                "String ToString(Object)",
                "String ToString(Object, IFormatProvider)",

                "Object To(Type, Object)",
                "Object To(Type, Object, IFormatProvider)",

                "T To(Object)",
                "T To(Object, IFormatProvider)",

                "Object ToDBValue(Object)"
            };
        }

        protected override IEnumerable<string> GetExistingStaticSignatures()
        {
            string[] methods = {
                "ToBoolean",
                "ToSByte",
                "ToInt16",
                "ToInt32",
                "ToInt64",
                "ToByte",
                "ToUInt16",
                "ToUInt32",
                "ToUInt64",
                "ToDecimal",
                "ToSingle",
                "ToDouble",
                "ToChar",
                "ToDateTime",
                "ToGuid",
                "ToNullableBoolean",
                "ToNullableSByte",
                "ToNullableInt16",
                "ToNullableInt32",
                "ToNullableInt64",
                "ToNullableByte",
                "ToNullableUInt16",
                "ToNullableUInt32",
                "ToNullableUInt64",
                "ToNullableDecimal",
                "ToNullableSingle",
                "ToNullableDouble",
                "ToNullableChar",
                "ToNullableDateTime",
                "ToNullableGuid",
                "ToString",
                "To",
                "ToDBValue",
            };

            var type = typeof(DBConvert);

            foreach (var method in methods)
                foreach (var signature in type.GetSignatures(method, BindingFlags.Public | BindingFlags.Static))
                    yield return signature;
        }

    }
}
