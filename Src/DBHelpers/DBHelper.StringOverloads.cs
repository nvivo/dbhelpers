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
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace DBHelpers
{
    public partial class DBHelper
    {
        #region ExecuteNonQuery

        public int ExecuteNonQuery(string commandText, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteNonQuery(command, connection);
        }

        public int ExecuteNonQuery(string commandText, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteNonQuery(command, transaction);
        }

        public int ExecuteNonQuery(string commandText)
        {
            var command = CreateCommand(commandText);
            return ExecuteNonQuery(command);
        }

        #endregion

        #region ExecuteNonQueryAsync

        public Task<int> ExecuteNonQueryAsync(string commandText, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteNonQueryAsync(command, connection);
        }

        public Task<int> ExecuteNonQueryAsync(string commandText, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteNonQueryAsync(command, transaction);
        }

        public Task<int> ExecuteNonQueryAsync(string commandText)
        {
            var command = CreateCommand(commandText);
            return ExecuteNonQueryAsync(command);
        }

        #endregion

        #region ExecuteScalar<T>

        public T ExecuteScalar<T>(string commandText, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteScalar<T>(command, connection);
        }

        public T ExecuteScalar<T>(string commandText, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteScalar<T>(command, transaction);
        }

        public T ExecuteScalar<T>(string commandText, Converter<object, T> converter, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteScalar<T>(command, converter, connection);
        }

        public T ExecuteScalar<T>(string commandText, Converter<object, T> converter, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteScalar<T>(command, converter, transaction);
        }

        public T ExecuteScalar<T>(string commandText)
        {
            var command = CreateCommand(commandText);
            return ExecuteScalar<T>(command);
        }

        public T ExecuteScalar<T>(string commandText, Converter<object, T> converter)
        {
            var command = CreateCommand(commandText);
            return ExecuteScalar<T>(command, converter);
        }

        #endregion

        #region ExecuteScalarAsync<T>

        public Task<T> ExecuteScalarAsync<T>(string commandText, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteScalarAsync<T>(command, connection);
        }

        public Task<T> ExecuteScalarAsync<T>(string commandText, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteScalarAsync<T>(command, transaction);
        }

        public Task<T> ExecuteScalarAsync<T>(string commandText, Converter<object, T> converter, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteScalarAsync<T>(command, converter, connection);
        }

        public Task<T> ExecuteScalarAsync<T>(string commandText, Converter<object, T> converter, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteScalarAsync<T>(command, converter, transaction);
        }

        public Task<T> ExecuteScalarAsync<T>(string commandText)
        {
            var command = CreateCommand(commandText);
            return ExecuteScalarAsync<T>(command);
        }

        public Task<T> ExecuteScalarAsync<T>(string commandText, Converter<object, T> converter)
        {
            var command = CreateCommand(commandText);
            return ExecuteScalarAsync<T>(command, converter);
        }

        #endregion

        #region ExecuteReader

        public DbDataReader ExecuteReader(string commandText, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteReader(command, connection);
        }

        public DbDataReader ExecuteReader(string commandText, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteReader(command, transaction);
        }

        public DbDataReader ExecuteReader(string commandText)
        {
            var command = CreateCommand(commandText);
            return ExecuteReader(command);
        }

        #endregion

        #region ExecuteReaderAsync

        public Task<DbDataReader> ExecuteReaderAsync(string commandText, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteReaderAsync(command, connection);
        }

        public Task<DbDataReader> ExecuteReaderAsync(string commandText, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteReaderAsync(command, transaction);
        }

        public Task<DbDataReader> ExecuteReaderAsync(string commandText)
        {
            var command = CreateCommand(commandText);
            return ExecuteReaderAsync(command);
        }

        #endregion

        #region ExecuteDataTable

        public DataTable ExecuteDataTable(string commandText, int startRecord, int maxRecords, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteDataTable(command, startRecord, maxRecords, connection);
        }

        public DataTable ExecuteDataTable(string commandText, int startRecord, int maxRecords, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteDataTable(command, startRecord, maxRecords, transaction);
        }

        public DataTable ExecuteDataTable(string commandText, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteDataTable(command, connection);
        }

        public DataTable ExecuteDataTable(string commandText, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteDataTable(command, transaction);
        }

        public DataTable ExecuteDataTable(string commandText, int startRecord, int maxRecords)
        {
            var command = CreateCommand(commandText);
            return ExecuteDataTable(command, startRecord, maxRecords);
        }

        public DataTable ExecuteDataTable(string commandText)
        {
            var command = CreateCommand(commandText);
            return ExecuteDataTable(command);
        }

        #endregion

        #region ExecuteDataTableAsync

        public Task<DataTable> ExecuteDataTableAsync(string commandText, int startRecord, int maxRecords, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteDataTableAsync(command, startRecord, maxRecords, connection);
        }

        public Task<DataTable> ExecuteDataTableAsync(string commandText, int startRecord, int maxRecords, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteDataTableAsync(command, startRecord, maxRecords, transaction);
        }

        public Task<DataTable> ExecuteDataTableAsync(string commandText, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteDataTableAsync(command, connection);
        }

        public Task<DataTable> ExecuteDataTableAsync(string commandText, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteDataTableAsync(command, transaction);
        }

        public Task<DataTable> ExecuteDataTableAsync(string commandText, int startRecord, int maxRecords)
        {
            var command = CreateCommand(commandText);
            return ExecuteDataTableAsync(command, startRecord, maxRecords);
        }

        public Task<DataTable> ExecuteDataTableAsync(string commandText)
        {
            var command = CreateCommand(commandText);
            return ExecuteDataTableAsync(command);
        }

        #endregion

        #region ExecuteDataSet

        public DataSet ExecuteDataSet(string commandText, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteDataSet(command, connection);
        }

        public DataSet ExecuteDataSet(string commandText, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteDataSet(command, transaction);
        }

        public Task<DataSet> ExecuteDataSetAsync(string commandText, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteDataSetAsync(command, connection);
        }

        public Task<DataSet> ExecuteDataSetAsync(string commandText, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteDataSetAsync(command, transaction);
        }

        public DataSet ExecuteDataSet(string commandText)
        {
            var command = CreateCommand(commandText);
            return ExecuteDataSet(command);
        }

        public Task<DataSet> ExecuteDataSetAsync(string commandText)
        {
            var command = CreateCommand(commandText);
            return ExecuteDataSetAsync(command);
        }

        #endregion

        #region ExecuteArray<T>

        public T[] ExecuteArray<T>(string commandText, int startRecord, int maxRecords, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteArray<T>(command, startRecord, maxRecords, connection);
        }

        public T[] ExecuteArray<T>(string commandText, int startRecord, int maxRecords, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteArray<T>(command, startRecord, maxRecords, transaction);
        }

        public T[] ExecuteArray<T>(string commandText, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteArray<T>(command, connection);
        }

        public T[] ExecuteArray<T>(string commandText, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteArray<T>(command, transaction);
        }

        public T[] ExecuteArray<T>(string commandText, Converter<object, T> converter, int startRecord, int maxRecords, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteArray<T>(command, converter, startRecord, maxRecords, connection);
        }

        public T[] ExecuteArray<T>(string commandText, Converter<object, T> converter, int startRecord, int maxRecords, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteArray<T>(command, converter, startRecord, maxRecords, transaction);
        }

        public T[] ExecuteArray<T>(string commandText, Converter<object, T> converter, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteArray<T>(command, converter, connection);
        }

        public T[] ExecuteArray<T>(string commandText, Converter<object, T> converter, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteArray<T>(command, converter, transaction);
        }

        public T[] ExecuteArray<T>(string commandText, int startRecord, int maxRecords)
        {
            var command = CreateCommand(commandText);
            return ExecuteArray<T>(command, startRecord, maxRecords);
        }

        public T[] ExecuteArray<T>(string commandText)
        {
            var command = CreateCommand(commandText);
            return ExecuteArray<T>(command);
        }

        public T[] ExecuteArray<T>(string commandText, Converter<object, T> converter, int startRecord, int maxRecords)
        {
            var command = CreateCommand(commandText);
            return ExecuteArray<T>(command, converter, startRecord, maxRecords);
        }

        public T[] ExecuteArray<T>(string commandText, Converter<object, T> converter)
        {
            var command = CreateCommand(commandText);
            return ExecuteArray<T>(command, converter);
        }

        #endregion

        #region ExecuteArrayAsync<T>

        public Task<T[]> ExecuteArrayAsync<T>(string commandText, int startRecord, int maxRecords, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteArrayAsync<T>(command, startRecord, maxRecords, connection);
        }

        public Task<T[]> ExecuteArrayAsync<T>(string commandText, int startRecord, int maxRecords, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteArrayAsync<T>(command, startRecord, maxRecords, transaction);
        }

        public Task<T[]> ExecuteArrayAsync<T>(string commandText, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteArrayAsync<T>(command, connection);
        }

        public Task<T[]> ExecuteArrayAsync<T>(string commandText, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteArrayAsync<T>(command, transaction);
        }

        public Task<T[]> ExecuteArrayAsync<T>(string commandText, Converter<object, T> converter, int startRecord, int maxRecords, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteArrayAsync<T>(command, converter, startRecord, maxRecords, connection);
        }

        public Task<T[]> ExecuteArrayAsync<T>(string commandText, Converter<object, T> converter, int startRecord, int maxRecords, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteArrayAsync<T>(command, converter, startRecord, maxRecords, transaction);
        }

        public Task<T[]> ExecuteArrayAsync<T>(string commandText, Converter<object, T> converter, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteArrayAsync<T>(command, converter, connection);
        }

        public Task<T[]> ExecuteArrayAsync<T>(string commandText, Converter<object, T> converter, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteArrayAsync<T>(command, converter, transaction);
        }

        public Task<T[]> ExecuteArrayAsync<T>(string commandText, int startRecord, int maxRecords)
        {
            var command = CreateCommand(commandText);
            return ExecuteArrayAsync<T>(command, startRecord, maxRecords);
        }

        public Task<T[]> ExecuteArrayAsync<T>(string commandText)
        {
            var command = CreateCommand(commandText);
            return ExecuteArrayAsync<T>(command);
        }

        public Task<T[]> ExecuteArrayAsync<T>(string commandText, Converter<object, T> converter, int startRecord, int maxRecords)
        {
            var command = CreateCommand(commandText);
            return ExecuteArrayAsync<T>(command, converter, startRecord, maxRecords);
        }

        public Task<T[]> ExecuteArrayAsync<T>(string commandText, Converter<object, T> converter)
        {
            var command = CreateCommand(commandText);
            return ExecuteArrayAsync<T>(command, converter);
        }

        #endregion

        #region ExecuteDictionary<TKey, TValue>

        public Dictionary<TKey, TValue> ExecuteDictionary<TKey, TValue>(string commandText, Converter<object, TKey> keyConverter, Converter<object, TValue> valueConverter, int startRecord, int maxRecords, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteDictionary<TKey, TValue>(command, keyConverter, valueConverter, startRecord, maxRecords, connection);
        }

        public Dictionary<TKey, TValue> ExecuteDictionary<TKey, TValue>(string commandText, Converter<object, TKey> keyConverter, Converter<object, TValue> valueConverter, int startRecord, int maxRecords, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteDictionary<TKey, TValue>(command, keyConverter, valueConverter, startRecord, maxRecords, transaction);
        }

        public Dictionary<TKey, TValue> ExecuteDictionary<TKey, TValue>(string commandText, Converter<object, TKey> keyConverter, Converter<object, TValue> valueConverter, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteDictionary<TKey, TValue>(command, keyConverter, valueConverter, connection);
        }

        public Dictionary<TKey, TValue> ExecuteDictionary<TKey, TValue>(string commandText, Converter<object, TKey> keyConverter, Converter<object, TValue> valueConverter, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteDictionary<TKey, TValue>(command, keyConverter, valueConverter, transaction);
        }

        public Dictionary<TKey, TValue> ExecuteDictionary<TKey, TValue>(string commandText, int startRecord, int maxRecords, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteDictionary<TKey, TValue>(command, startRecord, maxRecords, connection);
        }

        public Dictionary<TKey, TValue> ExecuteDictionary<TKey, TValue>(string commandText, int startRecord, int maxRecords, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteDictionary<TKey, TValue>(command, startRecord, maxRecords, transaction);
        }

        public Dictionary<TKey, TValue> ExecuteDictionary<TKey, TValue>(string commandText, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteDictionary<TKey, TValue>(command, connection);
        }

        public Dictionary<TKey, TValue> ExecuteDictionary<TKey, TValue>(string commandText, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteDictionary<TKey, TValue>(command, transaction);
        }

        public Dictionary<TKey, TValue> ExecuteDictionary<TKey, TValue>(string commandText, Converter<object, TKey> keyConverter, Converter<object, TValue> valueConverter, int startRecord, int maxRecords)
        {
            var command = CreateCommand(commandText);
            return ExecuteDictionary<TKey, TValue>(command, keyConverter, valueConverter, startRecord, maxRecords);
        }

        public Dictionary<TKey, TValue> ExecuteDictionary<TKey, TValue>(string commandText, Converter<object, TKey> keyConverter, Converter<object, TValue> valueConverter)
        {
            var command = CreateCommand(commandText);
            return ExecuteDictionary<TKey, TValue>(command, keyConverter, valueConverter);
        }

        public Dictionary<TKey, TValue> ExecuteDictionary<TKey, TValue>(string commandText, int startRecord, int maxRecords)
        {
            var command = CreateCommand(commandText);
            return ExecuteDictionary<TKey, TValue>(command, startRecord, maxRecords);
        }

        public Dictionary<TKey, TValue> ExecuteDictionary<TKey, TValue>(string commandText)
        {
            var command = CreateCommand(commandText);
            return ExecuteDictionary<TKey, TValue>(command);
        }

        #endregion

        #region ExecuteDictionaryAsync<TKey, TValue>

        public Task<Dictionary<TKey, TValue>> ExecuteDictionaryAsync<TKey, TValue>(string commandText, Converter<object, TKey> keyConverter, Converter<object, TValue> valueConverter, int startRecord, int maxRecords, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteDictionaryAsync<TKey, TValue>(command, keyConverter, valueConverter, startRecord, maxRecords, connection);
        }

        public Task<Dictionary<TKey, TValue>> ExecuteDictionaryAsync<TKey, TValue>(string commandText, Converter<object, TKey> keyConverter, Converter<object, TValue> valueConverter, int startRecord, int maxRecords, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteDictionaryAsync<TKey, TValue>(command, keyConverter, valueConverter, startRecord, maxRecords, transaction);
        }

        public Task<Dictionary<TKey, TValue>> ExecuteDictionaryAsync<TKey, TValue>(string commandText, Converter<object, TKey> keyConverter, Converter<object, TValue> valueConverter, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteDictionaryAsync<TKey, TValue>(command, keyConverter, valueConverter, connection);
        }

        public Task<Dictionary<TKey, TValue>> ExecuteDictionaryAsync<TKey, TValue>(string commandText, Converter<object, TKey> keyConverter, Converter<object, TValue> valueConverter, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteDictionaryAsync<TKey, TValue>(command, keyConverter, valueConverter, transaction);
        }

        public Task<Dictionary<TKey, TValue>> ExecuteDictionaryAsync<TKey, TValue>(string commandText, int startRecord, int maxRecords, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteDictionaryAsync<TKey, TValue>(command, startRecord, maxRecords, connection);
        }

        public Task<Dictionary<TKey, TValue>> ExecuteDictionaryAsync<TKey, TValue>(string commandText, int startRecord, int maxRecords, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteDictionaryAsync<TKey, TValue>(command, startRecord, maxRecords, transaction);
        }

        public Task<Dictionary<TKey, TValue>> ExecuteDictionaryAsync<TKey, TValue>(string commandText, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteDictionaryAsync<TKey, TValue>(command, connection);
        }

        public Task<Dictionary<TKey, TValue>> ExecuteDictionaryAsync<TKey, TValue>(string commandText, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteDictionaryAsync<TKey, TValue>(command, transaction);
        }

        public Task<Dictionary<TKey, TValue>> ExecuteDictionaryAsync<TKey, TValue>(string commandText, Converter<object, TKey> keyConverter, Converter<object, TValue> valueConverter, int startRecord, int maxRecords)
        {
            var command = CreateCommand(commandText);
            return ExecuteDictionaryAsync<TKey, TValue>(command, keyConverter, valueConverter, startRecord, maxRecords);
        }

        public Task<Dictionary<TKey, TValue>> ExecuteDictionaryAsync<TKey, TValue>(string commandText, Converter<object, TKey> keyConverter, Converter<object, TValue> valueConverter)
        {
            var command = CreateCommand(commandText);
            return ExecuteDictionaryAsync<TKey, TValue>(command, keyConverter, valueConverter);
        }

        public Task<Dictionary<TKey, TValue>> ExecuteDictionaryAsync<TKey, TValue>(string commandText, int startRecord, int maxRecords)
        {
            var command = CreateCommand(commandText);
            return ExecuteDictionaryAsync<TKey, TValue>(command, startRecord, maxRecords);
        }

        public Task<Dictionary<TKey, TValue>> ExecuteDictionaryAsync<TKey, TValue>(string commandText)
        {
            var command = CreateCommand(commandText);
            return ExecuteDictionaryAsync<TKey, TValue>(command);
        }

        #endregion

        #region ExecuteObject<T>

        public T ExecuteObject<T>(string commandText, Converter<DbDataReader, T> converter, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteObject<T>(command, converter, connection);
        }

        public T ExecuteObject<T>(string commandText, Converter<DbDataReader, T> converter, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteObject<T>(command, converter, transaction);
        }

        public T ExecuteObject<T>(string commandText, DbConnection connection)
            where T : new()
        {
            var command = CreateCommand(commandText);
            return ExecuteObject<T>(command, connection);
        }

        public T ExecuteObject<T>(string commandText, DbTransaction transaction)
            where T : new()
        {
            var command = CreateCommand(commandText);
            return ExecuteObject<T>(command, transaction);
        }

        public T ExecuteObject<T>(string commandText, Converter<DbDataReader, T> converter)
        {
            var command = CreateCommand(commandText);
            return ExecuteObject<T>(command, converter);
        }

        public T ExecuteObject<T>(string commandText)
            where T : new()
        {
            var command = CreateCommand(commandText);
            return ExecuteObject<T>(command);
        }

        #endregion

        #region ExecuteObjectAsync<T>

        public Task<T> ExecuteObjectAsync<T>(string commandText, Converter<DbDataReader, T> converter, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteObjectAsync<T>(command, converter, connection);
        }

        public Task<T> ExecuteObjectAsync<T>(string commandText, Converter<DbDataReader, T> converter, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteObjectAsync<T>(command, converter, transaction);
        }

        public Task<T> ExecuteObjectAsync<T>(string commandText, DbConnection connection)
            where T : new()
        {
            var command = CreateCommand(commandText);
            return ExecuteObjectAsync<T>(command, connection);
        }

        public Task<T> ExecuteObjectAsync<T>(string commandText, DbTransaction transaction)
            where T : new()
        {
            var command = CreateCommand(commandText);
            return ExecuteObjectAsync<T>(command, transaction);
        }

        public Task<T> ExecuteObjectAsync<T>(string commandText, Converter<DbDataReader, T> converter)
        {
            var command = CreateCommand(commandText);
            return ExecuteObjectAsync<T>(command, converter);
        }

        public Task<T> ExecuteObjectAsync<T>(string commandText)
            where T : new()
        {
            var command = CreateCommand(commandText);
            return ExecuteObjectAsync<T>(command);
        }

        #endregion

        #region ExecuteList<T>

        public List<T> ExecuteList<T>(string commandText, Converter<DbDataReader, T> converter, int startRecord, int maxRecords, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteList<T>(command, converter, startRecord, maxRecords, connection);
        }

        public List<T> ExecuteList<T>(string commandText, Converter<DbDataReader, T> converter, int startRecord, int maxRecords, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteList<T>(command, converter, startRecord, maxRecords, transaction);
        }

        public List<T> ExecuteList<T>(string commandText, Converter<DbDataReader, T> converter, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteList<T>(command, converter, connection);
        }

        public List<T> ExecuteList<T>(string commandText, Converter<DbDataReader, T> converter, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteList<T>(command, converter, transaction);
        }

        public List<T> ExecuteList<T>(string commandText, int startRecord, int maxRecords, DbConnection connection)
            where T : new()
        {
            var command = CreateCommand(commandText);
            return ExecuteList<T>(command, startRecord, maxRecords, connection);
        }

        public List<T> ExecuteList<T>(string commandText, int startRecord, int maxRecords, DbTransaction transaction)
            where T : new()
        {
            var command = CreateCommand(commandText);
            return ExecuteList<T>(command, startRecord, maxRecords, transaction);
        }

        public List<T> ExecuteList<T>(string commandText, DbConnection connection)
            where T : new()
        {
            var command = CreateCommand(commandText);
            return ExecuteList<T>(command, connection);
        }

        public List<T> ExecuteList<T>(string commandText, DbTransaction transaction)
            where T : new()
        {
            var command = CreateCommand(commandText);
            return ExecuteList<T>(command, transaction);
        }

        public List<T> ExecuteList<T>(string commandText, Converter<DbDataReader, T> converter, int startRecord, int maxRecords)
        {
            var command = CreateCommand(commandText);
            return ExecuteList<T>(command, converter, startRecord, maxRecords);
        }

        public List<T> ExecuteList<T>(string commandText, Converter<DbDataReader, T> converter)
        {
            var command = CreateCommand(commandText);
            return ExecuteList<T>(command, converter);
        }

        public List<T> ExecuteList<T>(string commandText, int startRecord, int maxRecords)
            where T : new()
        {
            var command = CreateCommand(commandText);
            return ExecuteList<T>(command, startRecord, maxRecords);
        }

        public List<T> ExecuteList<T>(string commandText)
            where T : new()
        {
            var command = CreateCommand(commandText);
            return ExecuteList<T>(command);
        }

        #endregion

        #region ExecuteListAsync<T>

        public Task<List<T>> ExecuteListAsync<T>(string commandText, Converter<DbDataReader, T> converter, int startRecord, int maxRecords, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteListAsync<T>(command, converter, startRecord, maxRecords, connection);
        }

        public Task<List<T>> ExecuteListAsync<T>(string commandText, Converter<DbDataReader, T> converter, int startRecord, int maxRecords, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteListAsync<T>(command, converter, startRecord, maxRecords, transaction);
        }

        public Task<List<T>> ExecuteListAsync<T>(string commandText, Converter<DbDataReader, T> converter, DbConnection connection)
        {
            var command = CreateCommand(commandText);
            return ExecuteListAsync<T>(command, converter, connection);
        }

        public Task<List<T>> ExecuteListAsync<T>(string commandText, Converter<DbDataReader, T> converter, DbTransaction transaction)
        {
            var command = CreateCommand(commandText);
            return ExecuteListAsync<T>(command, converter, transaction);
        }

        public Task<List<T>> ExecuteListAsync<T>(string commandText, int startRecord, int maxRecords, DbConnection connection)
            where T : new()
        {
            var command = CreateCommand(commandText);
            return ExecuteListAsync<T>(command, startRecord, maxRecords, connection);
        }

        public Task<List<T>> ExecuteListAsync<T>(string commandText, int startRecord, int maxRecords, DbTransaction transaction)
            where T : new()
        {
            var command = CreateCommand(commandText);
            return ExecuteListAsync<T>(command, startRecord, maxRecords, transaction);
        }

        public Task<List<T>> ExecuteListAsync<T>(string commandText, DbConnection connection)
            where T : new()
        {
            var command = CreateCommand(commandText);
            return ExecuteListAsync<T>(command, connection);
        }

        public Task<List<T>> ExecuteListAsync<T>(string commandText, DbTransaction transaction)
            where T : new()
        {
            var command = CreateCommand(commandText);
            return ExecuteListAsync<T>(command, transaction);
        }

        public Task<List<T>> ExecuteListAsync<T>(string commandText, Converter<DbDataReader, T> converter, int startRecord, int maxRecords)
        {
            var command = CreateCommand(commandText);
            return ExecuteListAsync<T>(command, converter, startRecord, maxRecords);
        }

        public Task<List<T>> ExecuteListAsync<T>(string commandText, Converter<DbDataReader, T> converter)
        {
            var command = CreateCommand(commandText);
            return ExecuteListAsync<T>(command, converter);
        }

        public Task<List<T>> ExecuteListAsync<T>(string commandText, int startRecord, int maxRecords)
            where T : new()
        {
            var command = CreateCommand(commandText);
            return ExecuteListAsync<T>(command, startRecord, maxRecords);
        }

        public Task<List<T>> ExecuteListAsync<T>(string commandText)
            where T : new()
        {
            var command = CreateCommand(commandText);
            return ExecuteListAsync<T>(command);
        }

        #endregion
    }
}
