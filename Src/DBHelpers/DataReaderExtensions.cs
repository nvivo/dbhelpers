using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBHelpers
{
    public static class DataReaderExtensions
    {
        #region Boolean

        public static bool? GetNullableBoolean(this DbDataReader reader, string fieldName, IFormatProvider provider)
        {
            return DBConvert.ToNullableBoolean(reader[fieldName], provider);
        }

        public static bool? GetNullableBoolean(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.ToNullableBoolean(reader[ordinal], provider);
        }

        public static bool? GetNullableBoolean(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToNullableBoolean(reader[fieldName]);
        }

        public static bool? GetNullableBoolean(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToNullableBoolean(reader[ordinal]);
        }

        public static bool GetBoolean(this DbDataReader reader, string fieldName, IFormatProvider provider)
        {
            return DBConvert.ToBoolean(reader[fieldName], provider);
        }

        public static bool GetBoolean(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.ToBoolean(reader[ordinal], provider);
        }

        public static bool GetBoolean(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToBoolean(reader[fieldName]);
        }

        public static bool GetBoolean_(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToBoolean(reader[ordinal]);
        }

        #endregion

        #region SByte

        public static sbyte? GetNullableSByte(this DbDataReader reader, string fieldName, IFormatProvider provider)
        {
            return DBConvert.ToNullableSByte(reader[fieldName], provider);
        }

        public static sbyte? GetNullableSByte(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.ToNullableSByte(reader[ordinal], provider);
        }

        public static sbyte? GetNullableSByte(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToNullableSByte(reader[fieldName]);
        }

        public static sbyte? GetNullableSByte(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToNullableSByte(reader[ordinal]);
        }

        public static sbyte GetSByte(this DbDataReader reader, string fieldName, IFormatProvider provider)
        {
            return DBConvert.ToSByte(reader[fieldName], provider);
        }

        public static sbyte GetSByte(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.ToSByte(reader[ordinal], provider);
        }

        public static sbyte GetSByte(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToSByte(reader[fieldName]);
        }

        public static sbyte GetSByte_(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToSByte(reader[ordinal]);
        }

        #endregion

        #region Int16

        public static short? GetNullableInt16(this DbDataReader reader, string fieldName, IFormatProvider provider)
        {
            return DBConvert.ToNullableInt16(reader[fieldName], provider);
        }

        public static short? GetNullableInt16(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.ToNullableInt16(reader[ordinal], provider);
        }

        public static short? GetNullableInt16(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToNullableInt16(reader[fieldName]);
        }

        public static short? GetNullableInt16(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToNullableInt16(reader[ordinal]);
        }

        public static short GetInt16(this DbDataReader reader, string fieldName, IFormatProvider provider)
        {
            return DBConvert.ToInt16(reader[fieldName], provider);
        }

        public static short GetInt16(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.ToInt16(reader[ordinal], provider);
        }

        public static short GetInt16(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToInt16(reader[fieldName]);
        }

        public static short GetInt16_(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToInt16(reader[ordinal]);
        }

        #endregion

        #region Int32

        public static int? GetNullableInt32(this DbDataReader reader, string fieldName, IFormatProvider provider)
        {
            return DBConvert.ToNullableInt32(reader[fieldName], provider);
        }

        public static int? GetNullableInt32(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.ToNullableInt32(reader[ordinal], provider);
        }

        public static int? GetNullableInt32(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToNullableInt32(reader[fieldName]);
        }

        public static int? GetNullableInt32(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToNullableInt32(reader[ordinal]);
        }

        public static int GetInt32(this DbDataReader reader, string fieldName, IFormatProvider provider)
        {
            return DBConvert.ToInt32(reader[fieldName], provider);
        }

        public static int GetInt32(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.ToInt32(reader[ordinal], provider);
        }

        public static int GetInt32(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToInt32(reader[fieldName]);
        }

        public static int GetInt32_(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToInt32(reader[ordinal]);
        }

        #endregion

        #region Int64

        public static long? GetNullableInt64(this DbDataReader reader, string fieldName, IFormatProvider provider)
        {
            return DBConvert.ToNullableInt64(reader[fieldName], provider);
        }

        public static long? GetNullableInt64(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.ToNullableInt64(reader[ordinal], provider);
        }

        public static long? GetNullableInt64(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToNullableInt64(reader[fieldName]);
        }

        public static long? GetNullableInt64(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToNullableInt64(reader[ordinal]);
        }

        public static long GetInt64(this DbDataReader reader, string fieldName, IFormatProvider provider)
        {
            return DBConvert.ToInt64(reader[fieldName], provider);
        }

        public static long GetInt64(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.ToInt64(reader[ordinal], provider);
        }

        public static long GetInt64(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToInt64(reader[fieldName]);
        }

        public static long GetInt64_(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToInt64(reader[ordinal]);
        }

        #endregion

        #region Byte

        public static byte? GetNullableByte(this DbDataReader reader, string fieldName, IFormatProvider provider)
        {
            return DBConvert.ToNullableByte(reader[fieldName], provider);
        }

        public static byte? GetNullableByte(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.ToNullableByte(reader[ordinal], provider);
        }

        public static byte? GetNullableByte(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToNullableByte(reader[fieldName]);
        }

        public static byte? GetNullableByte(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToNullableByte(reader[ordinal]);
        }

        public static byte GetByte(this DbDataReader reader, string fieldName, IFormatProvider provider)
        {
            return DBConvert.ToByte(reader[fieldName], provider);
        }

        public static byte GetByte(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.ToByte(reader[ordinal], provider);
        }

        public static byte GetByte(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToByte(reader[fieldName]);
        }

        public static byte GetByte_(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToByte(reader[ordinal]);
        }

        #endregion

        #region UInt16

        public static ushort? GetNullableUInt16(this DbDataReader reader, string fieldName, IFormatProvider provider)
        {
            return DBConvert.ToNullableUInt16(reader[fieldName], provider);
        }

        public static ushort? GetNullableUInt16(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.ToNullableUInt16(reader[ordinal], provider);
        }

        public static ushort? GetNullableUInt16(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToNullableUInt16(reader[fieldName]);
        }

        public static ushort? GetNullableUInt16(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToNullableUInt16(reader[ordinal]);
        }

        public static ushort GetUInt16(this DbDataReader reader, string fieldName, IFormatProvider provider)
        {
            return DBConvert.ToUInt16(reader[fieldName], provider);
        }

        public static ushort GetUInt16(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.ToUInt16(reader[ordinal], provider);
        }

        public static ushort GetUInt16(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToUInt16(reader[fieldName]);
        }

        public static ushort GetUInt16_(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToUInt16(reader[ordinal]);
        }

        #endregion

        #region UInt32

        public static uint? GetNullableUInt32(this DbDataReader reader, string fieldName, IFormatProvider provider)
        {
            return DBConvert.ToNullableUInt32(reader[fieldName], provider);
        }

        public static uint? GetNullableUInt32(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.ToNullableUInt32(reader[ordinal], provider);
        }

        public static uint? GetNullableUInt32(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToNullableUInt32(reader[fieldName]);
        }

        public static uint? GetNullableUInt32(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToNullableUInt32(reader[ordinal]);
        }

        public static uint GetUInt32(this DbDataReader reader, string fieldName, IFormatProvider provider)
        {
            return DBConvert.ToUInt32(reader[fieldName], provider);
        }

        public static uint GetUInt32(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.ToUInt32(reader[ordinal], provider);
        }

        public static uint GetUInt32(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToUInt32(reader[fieldName]);
        }

        public static uint GetUInt32_(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToUInt32(reader[ordinal]);
        }

        #endregion

        #region UInt64

        public static ulong? GetNullableUInt64(this DbDataReader reader, string fieldName, IFormatProvider provider)
        {
            return DBConvert.ToNullableUInt64(reader[fieldName], provider);
        }

        public static ulong? GetNullableUInt64(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.ToNullableUInt64(reader[ordinal], provider);
        }

        public static ulong? GetNullableUInt64(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToNullableUInt64(reader[fieldName]);
        }

        public static ulong? GetNullableUInt64(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToNullableUInt64(reader[ordinal]);
        }

        public static ulong GetUInt64(this DbDataReader reader, string fieldName, IFormatProvider provider)
        {
            return DBConvert.ToUInt64(reader[fieldName], provider);
        }

        public static ulong GetUInt64(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.ToUInt64(reader[ordinal], provider);
        }

        public static ulong GetUInt64(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToUInt64(reader[fieldName]);
        }

        public static ulong GetUInt64_(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToUInt64(reader[ordinal]);
        }

        #endregion

        #region Decimal

        public static decimal? GetNullableDecimal(this DbDataReader reader, string fieldName, IFormatProvider provider)
        {
            return DBConvert.ToNullableDecimal(reader[fieldName], provider);
        }

        public static decimal? GetNullableDecimal(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.ToNullableDecimal(reader[ordinal], provider);
        }

        public static decimal? GetNullableDecimal(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToNullableDecimal(reader[fieldName]);
        }

        public static decimal? GetNullableDecimal(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToNullableDecimal(reader[ordinal]);
        }

        public static decimal GetDecimal(this DbDataReader reader, string fieldName, IFormatProvider provider)
        {
            return DBConvert.ToDecimal(reader[fieldName], provider);
        }

        public static decimal GetDecimal(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.ToDecimal(reader[ordinal], provider);
        }

        public static decimal GetDecimal(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToDecimal(reader[fieldName]);
        }

        public static decimal GetDecimal_(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToDecimal(reader[ordinal]);
        }

        #endregion

        #region Single

        public static float? GetNullableSingle(this DbDataReader reader, string fieldName, IFormatProvider provider)
        {
            return DBConvert.ToNullableSingle(reader[fieldName], provider);
        }

        public static float? GetNullableSingle(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.ToNullableSingle(reader[ordinal], provider);
        }

        public static float? GetNullableSingle(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToNullableSingle(reader[fieldName]);
        }

        public static float? GetNullableSingle(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToNullableSingle(reader[ordinal]);
        }

        public static float GetSingle(this DbDataReader reader, string fieldName, IFormatProvider provider)
        {
            return DBConvert.ToSingle(reader[fieldName], provider);
        }

        public static float GetSingle(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.ToSingle(reader[ordinal], provider);
        }

        public static float GetSingle(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToSingle(reader[fieldName]);
        }

        public static float GetSingle_(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToSingle(reader[ordinal]);
        }

        #endregion

        #region Double

        public static double? GetNullableDouble(this DbDataReader reader, string fieldName, IFormatProvider provider)
        {
            return DBConvert.ToNullableDouble(reader[fieldName], provider);
        }

        public static double? GetNullableDouble(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.ToNullableDouble(reader[ordinal], provider);
        }

        public static double? GetNullableDouble(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToNullableDouble(reader[fieldName]);
        }

        public static double? GetNullableDouble(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToNullableDouble(reader[ordinal]);
        }

        public static double GetDouble(this DbDataReader reader, string fieldName, IFormatProvider provider)
        {
            return DBConvert.ToDouble(reader[fieldName], provider);
        }

        public static double GetDouble(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.ToDouble(reader[ordinal], provider);
        }

        public static double GetDouble(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToDouble(reader[fieldName]);
        }

        public static double GetDouble_(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToDouble(reader[ordinal]);
        }

        #endregion

        #region Char

        public static char? GetNullableChar(this DbDataReader reader, string fieldName, IFormatProvider provider)
        {
            return DBConvert.ToNullableChar(reader[fieldName], provider);
        }

        public static char? GetNullableChar(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.ToNullableChar(reader[ordinal], provider);
        }

        public static char? GetNullableChar(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToNullableChar(reader[fieldName]);
        }

        public static char? GetNullableChar(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToNullableChar(reader[ordinal]);
        }

        public static char GetChar(this DbDataReader reader, string fieldName, IFormatProvider provider)
        {
            return DBConvert.ToChar(reader[fieldName], provider);
        }

        public static char GetChar(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.ToChar(reader[ordinal], provider);
        }

        public static char GetChar(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToChar(reader[fieldName]);
        }

        public static char GetChar_(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToChar(reader[ordinal]);
        }

        #endregion

        #region DateTime

        public static DateTime? GetNullableDateTime(this DbDataReader reader, string fieldName, IFormatProvider provider)
        {
            return DBConvert.ToNullableDateTime(reader[fieldName], provider);
        }

        public static DateTime? GetNullableDateTime(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.ToNullableDateTime(reader[ordinal], provider);
        }

        public static DateTime? GetNullableDateTime(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToNullableDateTime(reader[fieldName]);
        }

        public static DateTime? GetNullableDateTime(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToNullableDateTime(reader[ordinal]);
        }

        public static DateTime GetDateTime(this DbDataReader reader, string fieldName, IFormatProvider provider)
        {
            return DBConvert.ToDateTime(reader[fieldName], provider);
        }

        public static DateTime GetDateTime(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.ToDateTime(reader[ordinal], provider);
        }

        public static DateTime GetDateTime(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToDateTime(reader[fieldName]);
        }

        public static DateTime GetDateTime_(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToDateTime(reader[ordinal]);
        }

        #endregion

        #region DateTimeOffset

        public static DateTimeOffset? GetNullableDateTimeOffset(this DbDataReader reader, string fieldName, IFormatProvider provider)
        {
            return DBConvert.ToNullableDateTimeOffset(reader[fieldName], provider);
        }

        public static DateTimeOffset? GetNullableDateTimeOffset(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.ToNullableDateTimeOffset(reader[ordinal], provider);
        }

        public static DateTimeOffset? GetNullableDateTimeOffset(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToNullableDateTimeOffset(reader[fieldName]);
        }

        public static DateTimeOffset? GetNullableDateTimeOffset(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToNullableDateTimeOffset(reader[ordinal]);
        }

        public static DateTimeOffset GetDateTimeOffset(this DbDataReader reader, string fieldName, IFormatProvider provider)
        {
            return DBConvert.ToDateTimeOffset(reader[fieldName], provider);
        }

        public static DateTimeOffset GetDateTimeOffset(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.ToDateTimeOffset(reader[ordinal], provider);
        }

        public static DateTimeOffset GetDateTimeOffset(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToDateTimeOffset(reader[fieldName]);
        }

        public static DateTimeOffset GetDateTimeOffset_(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToDateTimeOffset(reader[ordinal]);
        }

        #endregion

        #region String

        public static String GetString(this DbDataReader reader, string fieldName, IFormatProvider provider)
        {
            return DBConvert.ToString(reader[fieldName], provider);
        }

        public static String GetString(this DbDataReader reader, int ordinal, IFormatProvider provider)
        {
            return DBConvert.ToString(reader[ordinal], provider);
        }

        public static String GetString(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToString(reader[fieldName]);
        }

        public static String GetString_(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToString(reader[ordinal]);
        }

        #endregion

        #region Guid

        public static Guid? GetNullableGuid(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToNullableGuid(reader[fieldName]);
        }

        public static Guid? GetNullableGuid(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToNullableGuid(reader[ordinal]);
        }

        public static Guid GetGuid(this DbDataReader reader, string fieldName)
        {
            return DBConvert.ToGuid(reader[fieldName]);
        }

        public static Guid GetGuid_(this DbDataReader reader, int ordinal)
        {
            return DBConvert.ToGuid(reader[ordinal]);
        }

        #endregion
    }
}
