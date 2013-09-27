#region License
//  Copyright 2010-2013 Natan Vivo - http://github.com/nvivo/dbhelpers
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
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace DBHelpers
{
    public static class DBHelperExtensions
    {
        public static T[] ExecuteArray<T>(this DBHelper helper, string commandText, int startRecord, int maxRecords)
        {
            var command = helper.CreateCommand(commandText);
            return helper.ExecuteArray<T>(command, startRecord, maxRecords);
        }

        public static T[] ExecuteArray<T>(this DBHelper helper, string commandText)
        {
            var command = helper.CreateCommand(commandText);
            return helper.ExecuteArray<T>(command);
        }

        public static T[] ExecuteArray<T>(this DBHelper helper, string commandText, Converter<object, T> converter, int startRecord, int maxRecords)
        {
            var command = helper.CreateCommand(commandText);
            return helper.ExecuteArray<T>(command, converter, startRecord, maxRecords);
        }

        public static T[] ExecuteArray<T>(this DBHelper helper, string commandText, Converter<object, T> converter)
        {
            var command = helper.CreateCommand(commandText);
            return helper.ExecuteArray<T>(command, converter);
        }

        public static DataSet ExecuteDataSet(this DBHelper helper, string commandText)
        {
            var command = helper.CreateCommand(commandText);
            return helper.ExecuteDataSet(command);
        }

        public static DataTable ExecuteDataTable(this DBHelper helper, string commandText, int startRecord, int maxRecords)
        {
            var command = helper.CreateCommand(commandText);
            return helper.ExecuteDataTable(command, startRecord, maxRecords);
        }

        public static DataTable ExecuteDataTable(this DBHelper helper, string commandText)
        {
            var command = helper.CreateCommand(commandText);
            return helper.ExecuteDataTable(command);
        }

        public static Dictionary<TKey, TValue> ExecuteDictionary<TKey, TValue>(this DBHelper helper, string commandText, Converter<object, TKey> keyConverter, Converter<object, TValue> valueConverter, int startRecord, int maxRecords)
        {
            var command = helper.CreateCommand(commandText);
            return helper.ExecuteDictionary<TKey, TValue>(command, keyConverter, valueConverter, startRecord, maxRecords);
        }

        public static Dictionary<TKey, TValue> ExecuteDictionary<TKey, TValue>(this DBHelper helper, string commandText, Converter<object, TKey> keyConverter, Converter<object, TValue> valueConverter)
        {
            var command = helper.CreateCommand(commandText);
            return helper.ExecuteDictionary<TKey, TValue>(command, keyConverter, valueConverter);
        }

        public static Dictionary<TKey, TValue> ExecuteDictionary<TKey, TValue>(this DBHelper helper, string commandText, int startRecord, int maxRecords)
        {
            var command = helper.CreateCommand(commandText);
            return helper.ExecuteDictionary<TKey, TValue>(command, startRecord, maxRecords);
        }

        public static Dictionary<TKey, TValue> ExecuteDictionary<TKey, TValue>(this DBHelper helper, string commandText)
        {
            var command = helper.CreateCommand(commandText);
            return helper.ExecuteDictionary<TKey, TValue>(command);
        }

        public static List<T> ExecuteList<T>(this DBHelper helper, string commandText, Converter<DbDataReader, T> converter, int startRecord, int maxRecords)
        {
            var command = helper.CreateCommand(commandText);
            return helper.ExecuteList<T>(command, converter, startRecord, maxRecords);
        }

        public static List<T> ExecuteList<T>(this DBHelper helper, string commandText, Converter<DbDataReader, T> converter)
        {
            var command = helper.CreateCommand(commandText);
            return helper.ExecuteList<T>(command, converter);
        }

        public static List<T> ExecuteList<T>(this DBHelper helper, string commandText, int startRecord, int maxRecords)
                    where T : new()
        {
            var command = helper.CreateCommand(commandText);
            return helper.ExecuteList<T>(command, startRecord, maxRecords);
        }

        public static List<T> ExecuteList<T>(this DBHelper helper, string commandText)
                    where T : new()
        {
            var command = helper.CreateCommand(commandText);
            return helper.ExecuteList<T>(command);
        }

        public static int ExecuteNonQuery(this DBHelper helper, string commandText)
        {
            var command = helper.CreateCommand(commandText);
            return helper.ExecuteNonQuery(command);
        }

        public static T ExecuteObject<T>(this DBHelper helper, string commandText, Converter<DbDataReader, T> converter)
        {
            var command = helper.CreateCommand(commandText);
            return helper.ExecuteObject<T>(command, converter);
        }

        public static T ExecuteObject<T>(this DBHelper helper, string commandText)
                    where T : new()
        {
            var command = helper.CreateCommand(commandText);
            return helper.ExecuteObject<T>(command);
        }

        public static DbDataReader ExecuteReader(this DBHelper helper, string commandText)
        {
            var command = helper.CreateCommand(commandText);
            return helper.ExecuteReader(command);
        }

        public static T ExecuteScalar<T>(this DBHelper helper, string commandText)
        {
            var command = helper.CreateCommand(commandText);
            return helper.ExecuteScalar<T>(command);
        }

        public static T ExecuteScalar<T>(this DBHelper helper, string commandText, Converter<object, T> converter)
        {
            var command = helper.CreateCommand(commandText);
            return helper.ExecuteScalar<T>(command, converter);
        }
    }
}
