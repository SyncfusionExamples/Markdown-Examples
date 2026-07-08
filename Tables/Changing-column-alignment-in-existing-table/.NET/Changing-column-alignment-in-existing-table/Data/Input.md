# A tour of the C# language

C# (pronounced "See Sharp") is a modern, object-oriented, and type-safe programming language. C# enables developers to build many types of secure and robust applications that run in .NET. C# has its roots in the C family of languages and will be immediately familiar to C, C++, Java, and JavaScript programmers. This tour provides an overview of the major components of the language in C# 11 and earlier.


## Value types

C\#'s value types are further divided into *simple types*, *enum types*, *struct types*, *nullable value types*, and *tuple value types*.

| Value types | Details | Examples | Keyword |
|:---|:---|:---|:---|
| Simple types | Basic built-in types | `int`, `char`, `bool` | Primitive |
| Enum types | User-defined constants | `enum Days { Mon, Tue }` | Enum |
| Struct types | User-defined structures | `struct Point { int x; int y; }` | Struct |
| Nullable value types | Value types with `null` | `int?`, `bool?` | Nullable |
| Tuple value types | Group of values | `(int, string)` | Tuple |


## Reference types

|Reference types|Details|
|:---|:---|
|Class types |Ultimate base class of all other types: object.  |
|Interface types |User-defined types of the form interface I {...}|
|Array types |Single-dimensional, multi-dimensional, and jagged. |
|Delegate types |User-defined types of the form delegate int D(...) |
