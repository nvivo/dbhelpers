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

namespace DBHelpers
{
    public class RawValue
    {
        public RawValue(string value)
        {
            this.Value = value;
        }

        public string Value { get; private set; }
    }
}
