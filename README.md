# DBHelpers

DBHelpers is a simple but powerful library for working with plain ADO.NET.

There are countless frameworks for data access, but most of them get in the way when you need to run direct SQL.
If you want to optimize complex operations, or just want to run some sql without mapping classes, this library is for you.

This library is not intended to replace any big framework, but is a nice and lightweight addition to any project of any size and it will make you rethink how much you can do using plain ADO.NET.

## System Requirements

DBHelpers is coded for .NET 4.5 and should work with any .NET Data Provider.

## Installation


You can install DBHelpers from [Nuget](https://www.nuget.org/packages/DBHelpers/):

```
Install-Package DBHelpers
```

## Quick Start

This is not actually required, but makes it easier to work with DBHelper. If possible, add  the "providerName" to your connection string:

```xml
<connectionStrings>
    <add name="MyCN" connectionString="..." providerName="System.Data.SqlClient" />
</connectionStrings>
```
Then, instantiate the DBHelper:

```cs
using DBHelpers;
...
// if you have provided a providerName in the connectionString, you can just use the connection string name
var db = new DBHelper("MyCN");

// or instantiate it manually
var db = new DBHelper(System.Data.SqlClient.SqlClientFactory.Instance, "Server=localhost; ...");
```
And start calling the ExecuteXyz methods:
```cs
// returning a Scalar value
var count = db.ExecuteScalar<int>("select count(*) from table");

// returning a DataTable
var dt = db.ExecuteDataTable("select * from table");

// returning an object (properties are mapped if names match the columns)
var client = db.ExecuteObject<Client>("select * from client");
```

## More Details

ADO.NET is not hard to use, but as any low level component it requires a lot of plumbing. It requires you to explicitly open connections and remember to close them. It requires you to convert values and handle DBNulls. As you work with it, it becomes clear that many things could be automated. This library is basically a lot of overloads that do most of this plumbing and let you concentrate on what you need to do.

DBHelpers is composed of 2 main helper classes:

* **DBHelper**: handles query execution
* **DBConvert**: handles common cases of type conversion when using by ADO.NET (similar to System.Convert)

Once instantiated, DBHelper supports executing queries directly to the database and returning useful types in a single command. For example:

```cs
var lastDate  = db.ExecuteScalar<DateTime>("select max(change_date) from table");
var arr = db.ExecuteArray<int>("select id from table");
var dict = db.ExecuteDictionary<int, string>("select id, name from users");
var dt = db.ExecuteDataTable("select * from table");
```

The connection is automatically opened, closed and returned to the pool as quickly as possible.

You can execute any type of query and return any type of object. It support the regular old methods:

* `ExecuteNonQuery`
* `ExecuteReader`
* `ExecuteScalar<T>`

The exception is ExecuteScalar<T> which is typed and automatically converts values to the appropriate type.
Additionally we have some more useful methods:

* `ExecuteDataTable`
* `ExecuteDataSet`
* `ExecuteArray<T>`
* `ExecuteDictionary<TKey, TValue>`
* `ExecuteObject<T>`
* `ExecuteList<T>`

All methods are optimized for speed and will do as little as possible and return the data in the desired format.

### Automatic Type Conversion
---
When loading data from the database, values can be null/DBNull or can be of a slightly different type. DBHelpers adds some extension methods to DbDataReader, so you can safely expect certain types.

This is how you can read data from a table to a list of anonymous objects for quick use:

```cs
var list = DB.ExecuteList("select id, name, age from people", r => new {
    ID = r.Get<int>("id"),
    Name = r.Get<string>("name"),
    Age = r.Get<int?>("age")
});
```

DBHelper uses **DBConvert** under the hood for type conversion when it needs to. This class was based on System.Convert, and can be used directly in your code. It provides methods to convert all the basc types and some others between .NET and data providers. It is supposed to be used to get values out of DbDataReader and DataRows, and here is how you would use it:

```cs
string value = DBConvert.ToString(reader["someField"]);
int value = DBConvert.ToInt32(reader["someField"]);
int? value = DBConvert.ToNullableDateTime(reader["someField"]);
long? value = DBConvert.To<long?>(reader["someField"]);
Guid value = (Guid) DBConvert.To(typeof(Guid), reader["someField"]);

```
The core functionality of DBConvert for all "ToXyz" overloads is quite simple:

* If the value is a DBNull or null, return the default value for the type
* If the value is of the desired type or can be safely cast to that type, cast it and return
* If the value is something else, delegate to System.Convert (if possible)

This provides a quite safe experience for most cases and allow you to not care about DBNulls or conversions.

Here is what is expected:
```cs
var value = db.ExecuteScalar<int>("select cast(null as int)"); 
// int is a struct, so value = default(int) = 0

var value = db.ExecuteScalar<string>("select cast(null as varchar)"); 
// string is a reference type, so value = default(string) = null

var value = db.ExecuteScalar<int?>("select cast(null as int)"); 
// int? is a nullable, so value = default(int?) = null

var value = db.ExecuteScalar<byte>("select count(*) from t");
// value comes as int or long depending on the provider, but is converted to byte using System.Convert
```

Note that the idea is not to hide errors, but to avoid having to write obvious conversions. If you retrieve a byte[] and try to cast to a DateTime, you will get an exception. You are expected to know what you are doing. :-) Check [how System.Convert works](https://msdn.microsoft.com/en-us/library/system.convert(v=vs.110).aspx) for what you need, most of the actual conversion is done there when needed.

There is also a simple `DBConvert.ToDBValue(object)` that does one simple thing:

* If the value is null return DBNull.Value, else return the original value

This is used to when creating commands and passing values to DbParameters.

### Some other useful features
---

#### Async
All methods have `Async` versions, so you can use tasks. Async support is provided by the .NET data provider directly whenever possible.

```cs
await db.ExecuteNonQueryAsync("create table... "); 
var ids = await db.ExecuteScalarAsync<int>("select id from table");
using (var reader = await db.ExecuteReaderAsync(query)) { ... }
``` 

#### Batch execution

All methods have overloads to support using a specific connections, so you can can also run multiple operations in batch:

```cs
using (var connection = db.CreateConnection()) {
    connection.Open();
    db.ExecuteNonQuery(..., connection);
    db.ExecuteNonQuery(..., connection);
    db.ExecuteNonQuery(..., connection);
    return db.ExecuteScalar<int>(..., connection);
}
```

#### Custom converters

All methods that return values accept either `Converter<object, T>` or` Converter<DbDataReader, T>`, so you if you know what to expect, you can optimize with some manual conversion while still leveraging DBHelper:

```cs
// using reader directly with ordinal lookup
var list = db.ExecuteList("select top 10 id, name, age from user", reader => new User {
    ID = reader.GetInt32(0),
    Name = reader.GetString(1),
    Age = reader.IsDBNull(2) ? null : reader.GetInt32(2)
});

// if you know what is coming, just cast the value and avoid any checks
var count = db.ExecuteArray("select id from users", o => (int) o);

// you can also leverage existing methods for simple conversions
var dict = db.ExecuteDictionary("select id, name from users", Convert.ToInt32, Convert.ToString);
```

#### Multi table retrieval
You can retrieve multiple datatables at once:

```cs
var queries = @"
    select * from table1;
    select * from table2;
    select * from table3;
    select * from table4;
"
var dataset = db.ExecuteDataSet(queries);
```

#### Easy parameterized command generation

You can generate safe parameterized DbCommand objects for any database:

```cs
var command = db.CreateCommand("select * from users where name like {0}", userName + "%");
// generates "select * from users where name like @p0" in SQL Server and MySql
//           "select * from users where name like ?" in OleDb
```

All methods support passing string and DbCommand for maximum flexibility.

#### Automatic mapping of objects

Although this is not the focus of the library, it is sometimes useful to just load a table to an object. DBHelper provides a very simple mapper that matches column names to the properties. Mapping is case-insensitive. 

```cs
var user = db.ExecuteObject<User>("select * from user where id = 1");
var users = db.ExecuteList<User>("select * from user");
```

This is mostly provided as a utility method, for most cases it is better to provide a converter method.

#### Built in paging support

There is also a built-in paging mechanism that works with any database for all methods that return collections. If you are using this library, you can probably optimize using SQL directly. But some databases either don't support pagination or have very complicated syntax. This method uses the data reader to load only the amount of records you need, and is a good compromise for most situations.

```cs
var topUsers = db.ExecuteList<User>("select * from users", 0, 10);
var page = db.ExecuteDataTable("select * from users", 20, 10);
var arr = db.ExecuteArray("select id from top_visitors", 0, 100);
```

## Getting Help / Contributing

If you have any question, suggestion, feature request or found a bug, please use the [issue tracker](https://github.com/nvivo/dbhelpers/issues).
