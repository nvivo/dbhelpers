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

using System.Collections.Generic;
using System.Data.Common;
using System.Reflection;

namespace DBHelpers
{
    public class DataReaderConverter<T> where T : new()
    {
        private class Mapping
        {
            public int Index;
            public PropertyInfo Property;
        }

        private Mapping[] _mappings;
        private DbDataReader _lastReader;

        public T Convert(DbDataReader reader)
        {
            if (_mappings == null || reader != _lastReader)
                _mappings = MapProperties(reader);

            var o = new T();

            foreach (var mapping in _mappings)
            {
                var prop = mapping.Property;
                var rawValue = reader.GetValue(mapping.Index);
                var value = DBConvert.To(prop.PropertyType, rawValue);
                prop.SetValue(o, value, null);
            }

            _lastReader = reader;

            return o;
        }

        private Mapping[] MapProperties(DbDataReader reader)
        {
            var fieldCount = reader.FieldCount;

            var fields = new Dictionary<string, int>(fieldCount);

            for (var i = 0; i < fieldCount; i++)
                fields.Add(reader.GetName(i).ToLowerInvariant(), i);

            var type = typeof(T);

            var mapping = new List<Mapping>(fieldCount);

            foreach (var prop in type.GetProperties())
            {
                var name = prop.Name.ToLowerInvariant();

                int index;

                if (fields.TryGetValue(name, out index))
                    mapping.Add(new Mapping() { Index = index, Property = prop });
            }

            return mapping.ToArray();
        }
    }
}
