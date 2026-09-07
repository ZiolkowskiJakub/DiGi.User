#### [DiGi\.User](DiGi.User.Overview.md 'DiGi\.User\.Overview')

## DiGi\.User Namespace
### Classes

<a name='DiGi.User.Query'></a>

## Query Class

Provides static extension methods for resolving user permission levels\.

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.User.Query.UserLevel(thisint)'></a>

## Query\.UserLevel\(this int\) Method

Resolves an integer level value to the highest matching [UserLevel\(this int\)](DiGi.User.md#DiGi.User.Query.UserLevel(thisint) 'DiGi\.User\.Query\.UserLevel\(this int\)') tier\.

```csharp
public static DiGi.User.Enums.UserLevel UserLevel(this int level);
```
#### Parameters

<a name='DiGi.User.Query.UserLevel(thisint).level'></a>

`level` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The integer permission level to resolve\.

#### Returns
[UserLevel](DiGi.User.Enums.md#DiGi.User.Enums.UserLevel 'DiGi\.User\.Enums\.UserLevel')  
The corresponding [UserLevel\(this int\)](DiGi.User.md#DiGi.User.Query.UserLevel(thisint) 'DiGi\.User\.Query\.UserLevel\(this int\)') enum value\.