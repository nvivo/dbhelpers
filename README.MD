DBHelpers
=========

DBHelpers is a simple but powerful library for working with plain ADO.NET.

There are countless frameworks for data access, but most of them get in the way when you need to run direct SQL.
If you want to optimize complex operations, or just want to run some sql without mapping classes, this library is for you.

While this library is not intended for replacing any big framework, it is a nice addition to any project of any size and it will make you rethink how much you can do using plain ADO.NET.

System Requirements
-------------------

DBHelpers is coded for .NET 4.0 and should work with any .NET Data Provider.

Usage
-----

Make sure your connection string has the "providerName" set to your data provider.
```xml
<connectionStrings>
    <add name="MyCN" connectionString="..." providerName="System.Data.SqlClient" />
</connectionStrings>
```

Then, instantiate the DBHelper passing the name of your connection string. Simple like that:

```cs
var db = new DBHelper("MyCN");

// returning a Scalar value
var count = db.ExecuteScalar<int>("select count(*) from table");

// returning a DataTable
var dt = db.ExecuteDataTable("select * from table");

// returning an object (properties are mapped if names match the columns)
var client = db.ExecuteObject<Client>("select * from client");
```

Run multiple operations in a single connection:

```cs
using (var connection = db.CreateConnection()) {
    connection.Open();
    db.ExecuteNonQuery(..., connection);
    db.ExecuteNonQuery(..., connection);
    db.ExecuteNonQuery(..., connection);
}
```

Automatically create commands with parameters for any database:

```cs
var command = db.CreateCommand("select * from users where name like {0}", userName + "%");
// generates "select * from users where name like @p0" in SQL Server, parameter name will match the database format
```

Flexibility to mix parameters with string values for command creation:

```cs
var inClause = "(1, 2, 3, 4)";
var login = "mike@gmail.com";
var command = db.CreateCommand(
    "select * from users where login = {0} and state in {1}",
    login,
    new RawValue(inClause)
);

// generates: "select * from users where login = @p1 and state in (1, 2, 3, 4)";
```

Retrieve basic .NET data structures directly from the database:

```cs
var lastDate  = db.ExecuteScalar<DateTime>("select max(change_date) from table");
var arr = db.ExecuteArray<int>("select id from table");
var dict = db.ExecuteDictionary<int, string>("select id, name from users");
var dt = db.ExecuteDataTable("select * from table");
```

Retrieve multiple datatables at once:

```cs
var queries = @"
    select * from table1;
    select * from table2;
    select * from table3;
    select * from table4;
"
var dataset = db.ExecuteDataSet(queries);
```

Retrieve objects and lists automatically. The default mapping is done if the column name matches the property name. No extra code is required.

```cs
var user = db.ExecuteObject<User>("select * from user where id = 1");
var users = db.ExecuteList<User>("select * from user");
```

By default, DBHelpers already provide conversion for core data types using System.Convert, but if you need to do it yourself, no problem:

```cs
var arr = db.ExecuteScalar<int>("select uuid from users", o => Guid.Parse(o.ToString()));
var dict = db.ExecutDictionary<int, string>("select id from users", Convert.ToInt32, Convert.ToString);
```

You can also map objects using converters:

```cs
var user = db.ExecuteObject<User>("select * from users", reader => {
    var user = new User();
    
    user.ID = (int) reader["ID"];
    user.Name = (string) reader["Name"];
    
    return user;
});
```

There is also a built-in paging mechanism that works with any database for all methods that return collections. If for some reason you are not using LINQ or you cannot optimize your query for specific database, this is a good compromise.

```  
var topUsers = db.ExecuteList<User>("select * from users", 0, 10);
var page = db.ExecuteDataTable("select * from users", 20, 10);
var arr = db.ExecuteArray("select id from top_visitors", 0, 100);
```

