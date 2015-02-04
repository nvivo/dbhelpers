#region License
//  Copyright 2010-2015 Natan Vivo - http://github.com/nvivo/dbhelpers
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
#endregion

using System;
using System.Globalization;

namespace DBHelpers
{
    public class DBConvert
    {
        #region Boolean

        private static bool ToBooleanInternal(object value, IFormatProvider provider)
        {
            string s = value as string;
            bool b;

            if (s != null && Boolean.TryParse(s, out b))
                return b;

            if ((s = value.ToString()) != null)
            {
                int i;

                if (Int32.TryParse(s, out i))
                    return i != 0;
            }

            return Convert.ToBoolean(value, provider);
        }

        public static bool? ToNullableBoolean(object value, IFormatProvider provider)
        {
            return ToNullable<bool>(value, provider, ToBooleanInternal);
        }

        public static bool? ToNullableBoolean(object value)
        {
            return ToNullable<bool>(value, CultureInfo.CurrentCulture, ToBooleanInternal);
        }

        public static bool ToBoolean(object value, IFormatProvider provider)
        {
            return To<bool>(value, provider, ToBooleanInternal);
        }

        public static bool ToBoolean(object value)
        {
            return To<bool>(value, CultureInfo.CurrentCulture, ToBooleanInternal);
        }

        #endregion

        #region SByte

        private static sbyte ToSByteInternal(object value, IFormatProvider provider)
        {
            return Convert.ToSByte(value, provider);
        }

        public static sbyte? ToNullableSByte(object value, IFormatProvider provider)
        {
            return ToNullable<sbyte>(value, provider, ToSByteInternal);
        }

        public static sbyte? ToNullableSByte(object value)
        {
            return ToNullable<sbyte>(value, CultureInfo.CurrentCulture, ToSByteInternal);
        }

        public static sbyte ToSByte(object value, IFormatProvider provider)
        {
            return To<sbyte>(value, provider, ToSByteInternal);
        }

        public static sbyte ToSByte(object value)
        {
            return To<sbyte>(value, CultureInfo.CurrentCulture, ToSByteInternal);
        }

        #endregion

        #region Int16

        private static short ToInt16Internal(object value, IFormatProvider provider)
        {
            return Convert.ToInt16(value, provider);
        }

        public static short? ToNullableInt16(object value, IFormatProvider provider)
        {
            return ToNullable<short>(value, provider, ToInt16Internal);
        }

        public static short? ToNullableInt16(object value)
        {
            return ToNullable<short>(value, CultureInfo.CurrentCulture, ToInt16Internal);
        }

        public static short ToInt16(object value, IFormatProvider provider)
        {
            return To<short>(value, provider, ToInt16Internal);
        }

        public static short ToInt16(object value)
        {
            return To<short>(value, CultureInfo.CurrentCulture, ToInt16Internal);
        }

        #endregion

        #region Int32

        private static int ToInt32Internal(object value, IFormatProvider provider)
        {
            return Convert.ToInt32(value, provider);
        }

        public static int? ToNullableInt32(object value, IFormatProvider provider)
        {
            return ToNullable<int>(value, provider, ToInt32Internal);
        }

        public static int? ToNullableInt32(object value)
        {
            return ToNullable<int>(value, CultureInfo.CurrentCulture, ToInt32Internal);
        }

        public static int ToInt32(object value, IFormatProvider provider)
        {
            return To<int>(value, provider, ToInt32Internal);
        }

        public static int ToInt32(object value)
        {
            return To<int>(value, CultureInfo.CurrentCulture, ToInt32Internal);
        }

        #endregion

        #region Int64

        private static long ToInt64Internal(object value, IFormatProvider provider)
        {
            return Convert.ToInt64(value, provider);
        }

        public static long? ToNullableInt64(object value, IFormatProvider provider)
        {
            return ToNullable<long>(value, provider, ToInt64Internal);
        }

        public static long? ToNullableInt64(object value)
        {
            return ToNullable<long>(value, CultureInfo.CurrentCulture, ToInt64Internal);
        }

        public static long ToInt64(object value, IFormatProvider provider)
        {
            return To<long>(value, provider, ToInt64Internal);
        }

        public static long ToInt64(object value)
        {
            return To<long>(value, CultureInfo.CurrentCulture, ToInt64Internal);
        }

        #endregion

        #region Byte

        private static byte ToByteInternal(object value, IFormatProvider provider)
        {
            return Convert.ToByte(value, provider);
        }

        public static byte? ToNullableByte(object value, IFormatProvider provider)
        {
            return ToNullable<byte>(value, provider, ToByteInternal);
        }

        public static byte? ToNullableByte(object value)
        {
            return ToNullable<byte>(value, CultureInfo.CurrentCulture, ToByteInternal);
        }

        public static byte ToByte(object value, IFormatProvider provider)
        {
            return To<byte>(value, provider, ToByteInternal);
        }

        public static byte ToByte(object value)
        {
            return To<byte>(value, CultureInfo.CurrentCulture, ToByteInternal);
        }

        #endregion

        #region UInt16

        private static ushort ToUInt16Internal(object value, IFormatProvider provider)
        {
            return Convert.ToUInt16(value, provider);
        }

        public static ushort? ToNullableUInt16(object value, IFormatProvider provider)
        {
            return ToNullable<ushort>(value, provider, ToUInt16Internal);
        }

        public static ushort? ToNullableUInt16(object value)
        {
            return ToNullable<ushort>(value, CultureInfo.CurrentCulture, ToUInt16Internal);
        }

        public static ushort ToUInt16(object value, IFormatProvider provider)
        {
            return To<ushort>(value, provider, ToUInt16Internal);
        }

        public static ushort ToUInt16(object value)
        {
            return To<ushort>(value, CultureInfo.CurrentCulture, ToUInt16Internal);
        }

        #endregion

        #region UInt32

        private static uint ToUInt32Internal(object value, IFormatProvider provider)
        {
            return Convert.ToUInt32(value, provider);
        }

        public static uint? ToNullableUInt32(object value, IFormatProvider provider)
        {
            return ToNullable<uint>(value, provider, ToUInt32Internal);
        }

        public static uint? ToNullableUInt32(object value)
        {
            return ToNullable<uint>(value, CultureInfo.CurrentCulture, ToUInt32Internal);
        }

        public static uint ToUInt32(object value, IFormatProvider provider)
        {
            return To<uint>(value, provider, ToUInt32Internal);
        }

        public static uint ToUInt32(object value)
        {
            return To<uint>(value, CultureInfo.CurrentCulture, ToUInt32Internal);
        }

        #endregion

        #region UInt64

        private static ulong ToUInt64Internal(object value, IFormatProvider provider)
        {
            return Convert.ToUInt64(value, provider);
        }

        public static ulong? ToNullableUInt64(object value, IFormatProvider provider)
        {
            return ToNullable<ulong>(value, provider, ToUInt64Internal);
        }

        public static ulong? ToNullableUInt64(object value)
        {
            return ToNullable<ulong>(value, CultureInfo.CurrentCulture, ToUInt64Internal);
        }

        public static ulong ToUInt64(object value, IFormatProvider provider)
        {
            return To<ulong>(value, provider, ToUInt64Internal);
        }

        public static ulong ToUInt64(object value)
        {
            return To<ulong>(value, CultureInfo.CurrentCulture, ToUInt64Internal);
        }

        #endregion

        #region Decimal

        private static decimal ToDecimalInternal(object value, IFormatProvider provider)
        {
            return Convert.ToDecimal(value, provider);
        }

        public static decimal? ToNullableDecimal(object value, IFormatProvider provider)
        {
            return ToNullable<decimal>(value, provider, ToDecimalInternal);
        }

        public static decimal? ToNullableDecimal(object value)
        {
            return ToNullable<decimal>(value, CultureInfo.CurrentCulture, ToDecimalInternal);
        }

        public static decimal ToDecimal(object value, IFormatProvider provider)
        {
            return To<decimal>(value, provider, ToDecimalInternal);
        }

        public static decimal ToDecimal(object value)
        {
            return To<decimal>(value, CultureInfo.CurrentCulture, ToDecimalInternal);
        }

        #endregion

        #region Single

        private static float ToSingleInternal(object value, IFormatProvider provider)
        {
            return Convert.ToSingle(value, provider);
        }

        public static float? ToNullableSingle(object value, IFormatProvider provider)
        {
            return ToNullable<float>(value, provider, ToSingleInternal);
        }

        public static float? ToNullableSingle(object value)
        {
            return ToNullable<float>(value, CultureInfo.CurrentCulture, ToSingleInternal);
        }

        public static float ToSingle(object value, IFormatProvider provider)
        {
            return To<float>(value, provider, ToSingleInternal);
        }

        public static float ToSingle(object value)
        {
            return To<float>(value, CultureInfo.CurrentCulture, ToSingleInternal);
        }

        #endregion

        #region Double

        private static double ToDoubleInternal(object value, IFormatProvider provider)
        {
            return Convert.ToDouble(value, provider);
        }

        public static double? ToNullableDouble(object value, IFormatProvider provider)
        {
            return ToNullable<double>(value, provider, ToDoubleInternal);
        }

        public static double? ToNullableDouble(object value)
        {
            return ToNullable<double>(value, CultureInfo.CurrentCulture, ToDoubleInternal);
        }

        public static double ToDouble(object value, IFormatProvider provider)
        {
            return To<double>(value, provider, ToDoubleInternal);
        }

        public static double ToDouble(object value)
        {
            return To<double>(value, CultureInfo.CurrentCulture, ToDoubleInternal);
        }

        #endregion

        #region Char

        private static char ToCharInternal(object value, IFormatProvider provider)
        {
            var s = value as string;

            if (!String.IsNullOrEmpty(s))
                return s[0];
            
            return Convert.ToChar(value, provider);
        }

        public static char? ToNullableChar(object value, IFormatProvider provider)
        {
            return ToNullable<char>(value, provider, ToCharInternal);
        }

        public static char? ToNullableChar(object value)
        {
            return ToNullable<char>(value, CultureInfo.CurrentCulture, ToCharInternal);
        }

        public static char ToChar(object value, IFormatProvider provider)
        {
            return To<char>(value, provider, ToCharInternal);
        }

        public static char ToChar(object value)
        {
            return To<char>(value, CultureInfo.CurrentCulture, ToCharInternal);
        }

        #endregion

        #region DateTime

        private static DateTime ToDateTimeInternal(object value, IFormatProvider provider)
        {
            return Convert.ToDateTime(value, provider);
        }

        public static DateTime? ToNullableDateTime(object value, IFormatProvider provider)
        {
            return ToNullable<DateTime>(value, provider, ToDateTimeInternal);
        }

        public static DateTime? ToNullableDateTime(object value)
        {
            return ToNullable<DateTime>(value, CultureInfo.CurrentCulture, ToDateTimeInternal);
        }

        public static DateTime ToDateTime(object value, IFormatProvider provider)
        {
            return To<DateTime>(value, provider, ToDateTimeInternal);
        }

        public static DateTime ToDateTime(object value)
        {
            return To<DateTime>(value, CultureInfo.CurrentCulture, ToDateTimeInternal);
        }

        #endregion

        #region DateTimeOffset

        private static DateTimeOffset ToDateTimeOffsetInternal(object value, IFormatProvider provider, DateTimeStyles styles)
        {
            if (value is DateTime)
                return (DateTimeOffset) value;

            return DateTimeOffset.Parse(value.ToString(), provider, styles);
        }

        private static DateTimeOffset ToDateTimeOffsetInternal(object value, IFormatProvider provider)
        {
            return ToDateTimeOffsetInternal(value, provider, DateTimeStyles.None);
        }

        public static DateTimeOffset? ToNullableDateTimeOffset(object value, IFormatProvider provider)
        {
            return ToNullable<DateTimeOffset>(value, provider, ToDateTimeOffsetInternal);
        }

        public static DateTimeOffset? ToNullableDateTimeOffset(object value)
        {
            return ToNullable<DateTimeOffset>(value, CultureInfo.CurrentCulture, ToDateTimeOffsetInternal);
        }

        public static DateTimeOffset ToDateTimeOffset(object value, IFormatProvider provider)
        {
            return To<DateTimeOffset>(value, provider, ToDateTimeOffsetInternal);
        }

        public static DateTimeOffset ToDateTimeOffset(object value)
        {
            return To<DateTimeOffset>(value, CultureInfo.CurrentCulture, ToDateTimeOffsetInternal);
        }

        #endregion

        #region String

        private static string ToStringInternal(object value, IFormatProvider provider)
        {
            return Convert.ToString(value, provider);
        }

        public static string ToString(object value, IFormatProvider provider)
        {
            return To<string>(value, provider, ToStringInternal);
        }

        public static string ToString(object value)
        {
            return To<string>(value, CultureInfo.CurrentCulture, ToStringInternal);
        }

        #endregion

        #region Guid

        // This method accepts IFormatProvider just to match the signature required by
        // To<T> and ToNullable<T>, but it is not used
        private static Guid ToGuidInternal(object value, IFormatProvider provider)
        {
            byte[] bytes = value as byte[];

            if (bytes != null)
                return new Guid(bytes);

            return new Guid(value.ToString());
        }

        public static Guid? ToNullableGuid(object value)
        {
            return ToNullable<Guid>(value, null, ToGuidInternal);
        }

        public static Guid ToGuid(object value)
        {
            return To<Guid>(value, null, ToGuidInternal);
        }

        #endregion

        #region ByteArray

        public static byte[] ToByteArray(object value)
        {
            if (value is byte[])
                return (byte[])value;
            
            if (value == null || value == DBNull.Value)
                return null;
            
            throw new FormatException("Cannot cast value to byte[].");
        }

        #endregion

        #region To

        public static T To<T>(object value)
        {
            return To<T>(value, CultureInfo.CurrentCulture);
        }

        public static T To<T>(object value, IFormatProvider provider)
        {
            if (value is T)
                return (T)value;

            if (value == null || value == DBNull.Value)
                return default(T);

            return (T)To(typeof(T), value, provider);
        }

        public static object To(Type type, object value)
        {
            return To(type, value, CultureInfo.CurrentCulture);
        }

        public static object To(Type type, object value, IFormatProvider provider)
        {
            if (type == null)
                throw new ArgumentNullException("type");

            if (value != null && value.GetType() == type)
                return value;

            var isNullable = IsNullable(type);

            if (isNullable)
                type = Nullable.GetUnderlyingType(type);

            if (value == null || value == DBNull.Value)
            {
                if (isNullable || !type.IsValueType)
                    return null;
                else
                    return Activator.CreateInstance(type);
            }

            var typeCode = Type.GetTypeCode(type);

            switch (typeCode)
            {
                case TypeCode.Boolean:
                    return ToBooleanInternal(value, provider);

                case TypeCode.SByte:
                    return ToSByteInternal(value, provider);

                case TypeCode.Int16:
                    return ToInt16Internal(value, provider);

                case TypeCode.Int32:
                    return ToInt32Internal(value, provider);

                case TypeCode.Int64:
                    return ToInt64Internal(value, provider);

                case TypeCode.Byte:
                    return ToByteInternal(value, provider);

                case TypeCode.UInt16:
                    return ToUInt16Internal(value, provider);

                case TypeCode.UInt32:
                    return ToUInt32Internal(value, provider);

                case TypeCode.UInt64:
                    return ToUInt64Internal(value, provider);

                case TypeCode.Decimal:
                    return ToDecimalInternal(value, provider);

                case TypeCode.Single:
                    return ToSingleInternal(value, provider);

                case TypeCode.Double:
                    return ToDoubleInternal(value, provider);

                case TypeCode.Char:
                    return ToCharInternal(value, provider);

                case TypeCode.DateTime:
                    return ToDateTimeInternal(value, provider);

                case TypeCode.String:
                    return ToStringInternal(value, provider);

                case TypeCode.Object:
                    if (type == typeof(Guid))
                        return ToGuidInternal(value, null);

                    if (type == typeof(byte[]))
                        return ToByteArray(value);

                    if (type == typeof(DateTimeOffset))
                        return ToDateTimeOffsetInternal(value, null);

                    break;
            }

            // fallback to System.Convert for IConvertible types
            return Convert.ChangeType(value, typeCode, provider);
        }

        #endregion

        #region ToDBValue

        public static object ToDBValue(object value)
        {
            if (value == null)
                return DBNull.Value;

            return value;
        }

        #endregion

        #region Internal Private Helpers

        private static T? ToNullable<T>(object value, IFormatProvider provider, Func<object, IFormatProvider, T> converter)
            where T : struct
        {
            if (value is T)
                return (T)value;

            if (value == null || value == DBNull.Value)
                return null;

            return converter(value, provider);
        }

        private static T To<T>(object value, IFormatProvider provider, Func<object, IFormatProvider, T> converter)
        {
            if (value is T)
                return (T)value;

            if (value == null || value == DBNull.Value)
                return default(T);

            return converter(value, provider);
        }

        private static bool IsNullable(Type type)
        {
            return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);
        }

        #endregion
    }
}
