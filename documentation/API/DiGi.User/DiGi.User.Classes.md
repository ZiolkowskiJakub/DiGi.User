#### [DiGi\.User](DiGi.User.Overview.md 'DiGi\.User\.Overview')

## DiGi\.User\.Classes Namespace
### Classes

<a name='DiGi.User.Classes.User'></a>

## User Class

Represents a user within the system, providing properties for identity and contact information and supporting serialization\.

```csharp
public class User : DiGi.Core.Classes.SerializableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → User
### Constructors

<a name='DiGi.User.Classes.User.User(DiGi.User.Classes.User)'></a>

## User\(User\) Constructor

Initializes a new instance of the User class by copying another User object\.

```csharp
public User(DiGi.User.Classes.User user);
```
#### Parameters

<a name='DiGi.User.Classes.User.User(DiGi.User.Classes.User).user'></a>

`user` [User](DiGi.User.Classes.md#DiGi.User.Classes.User 'DiGi\.User\.Classes\.User')

The source User object to copy from\.

<a name='DiGi.User.Classes.User.User(string)'></a>

## User\(string\) Constructor

Initializes a new instance of the User class with a specified email\.

```csharp
public User(string? email);
```
#### Parameters

<a name='DiGi.User.Classes.User.User(string).email'></a>

`email` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The email address of the user\.

<a name='DiGi.User.Classes.User.User(System.Text.Json.Nodes.JsonObject)'></a>

## User\(JsonObject\) Constructor

Initializes a new instance of the User class from a JsonObject\.

```csharp
public User(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.User.Classes.User.User(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing user data\.
### Properties

<a name='DiGi.User.Classes.User.Email'></a>

## User\.Email Property

Gets or sets the email address of the user\.

```csharp
public string? Email { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.User.Classes.User.FirstName'></a>

## User\.FirstName Property

Gets or sets the first name of the user\.

```csharp
public string? FirstName { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.User.Classes.User.LastName'></a>

## User\.LastName Property

Gets or sets the last name of the user\.

```csharp
public string? LastName { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.User.Classes.User.Level'></a>

## User\.Level Property

Gets or sets the permission level of the user\.

The value uses a tiered gradient scale with one-order-of-magnitude gaps between tiers
            (Guest = 0, User = 10, Admin = 100, Owner = 1000), so intermediate levels
            can be inserted later without renumbering. Use [GetUserLevel\(\)](DiGi.User.Classes.md#DiGi.User.Classes.User.GetUserLevel() 'DiGi\.User\.Classes\.User\.GetUserLevel\(\)') to resolve the
            integer to its [UserLevel](DiGi.User.Enums.md#DiGi.User.Enums.UserLevel 'DiGi\.User\.Enums\.UserLevel') tier.

```csharp
public int Level { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')
### Methods

<a name='DiGi.User.Classes.User.GetUserLevel()'></a>

## User\.GetUserLevel\(\) Method

Resolves the [Level](DiGi.User.Classes.md#DiGi.User.Classes.User.Level 'DiGi\.User\.Classes\.User\.Level') integer to the highest matching [UserLevel](DiGi.User.Enums.md#DiGi.User.Enums.UserLevel 'DiGi\.User\.Enums\.UserLevel') tier\.

```csharp
public DiGi.User.Enums.UserLevel GetUserLevel();
```

#### Returns
[UserLevel](DiGi.User.Enums.md#DiGi.User.Enums.UserLevel 'DiGi\.User\.Enums\.UserLevel')  
The corresponding [UserLevel](DiGi.User.Enums.md#DiGi.User.Enums.UserLevel 'DiGi\.User\.Enums\.UserLevel') enum value\.

<a name='DiGi.User.Classes.UserCredential'></a>

## UserCredential Class

Represents the stored password credential of a user, keyed by the same unique email as the [User](DiGi.User.Classes.md#DiGi.User.Classes.User 'DiGi\.User\.Classes\.User') it belongs to\.

The password itself is never stored. [PasswordHash](DiGi.User.Classes.md#DiGi.User.Classes.UserCredential.PasswordHash 'DiGi\.User\.Classes\.UserCredential\.PasswordHash') holds the Base64 encoded PBKDF2 derived key of the
            password, salted with [PasswordSalt](DiGi.User.Classes.md#DiGi.User.Classes.UserCredential.PasswordSalt 'DiGi\.User\.Classes\.UserCredential\.PasswordSalt') and stretched over [PasswordIterations](DiGi.User.Classes.md#DiGi.User.Classes.UserCredential.PasswordIterations 'DiGi\.User\.Classes\.UserCredential\.PasswordIterations') iterations. The
            iteration count is stored per credential so it can be raised later without invalidating the credentials already written.

This type exists for storage and verification only. It carries the material an offline attack needs and MUST NEVER be
            returned from an endpoint, logged, or embedded in the [User](DiGi.User.Classes.md#DiGi.User.Classes.User 'DiGi\.User\.Classes\.User') payload.

```csharp
public class UserCredential : DiGi.Core.Classes.SerializableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → UserCredential
### Constructors

<a name='DiGi.User.Classes.UserCredential.UserCredential(DiGi.User.Classes.UserCredential)'></a>

## UserCredential\(UserCredential\) Constructor

Initializes a new instance of the UserCredential class by copying another UserCredential object\.

```csharp
public UserCredential(DiGi.User.Classes.UserCredential userCredential);
```
#### Parameters

<a name='DiGi.User.Classes.UserCredential.UserCredential(DiGi.User.Classes.UserCredential).userCredential'></a>

`userCredential` [UserCredential](DiGi.User.Classes.md#DiGi.User.Classes.UserCredential 'DiGi\.User\.Classes\.UserCredential')

The source UserCredential object to copy from\.

<a name='DiGi.User.Classes.UserCredential.UserCredential(string,string,string,int)'></a>

## UserCredential\(string, string, string, int\) Constructor

Initializes a new instance of the UserCredential class\.

```csharp
public UserCredential(string? email, string? passwordHash, string? passwordSalt, int passwordIterations);
```
#### Parameters

<a name='DiGi.User.Classes.UserCredential.UserCredential(string,string,string,int).email'></a>

`email` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The email address of the user the credential belongs to\.

<a name='DiGi.User.Classes.UserCredential.UserCredential(string,string,string,int).passwordHash'></a>

`passwordHash` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The Base64 encoded PBKDF2 derived key of the password\.

<a name='DiGi.User.Classes.UserCredential.UserCredential(string,string,string,int).passwordSalt'></a>

`passwordSalt` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The Base64 encoded salt the derived key was produced with\.

<a name='DiGi.User.Classes.UserCredential.UserCredential(string,string,string,int).passwordIterations'></a>

`passwordIterations` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of PBKDF2 iterations the derived key was produced with\.

<a name='DiGi.User.Classes.UserCredential.UserCredential(System.Text.Json.Nodes.JsonObject)'></a>

## UserCredential\(JsonObject\) Constructor

Initializes a new instance of the UserCredential class from a JsonObject\.

```csharp
public UserCredential(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.User.Classes.UserCredential.UserCredential(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing user credential data\.
### Properties

<a name='DiGi.User.Classes.UserCredential.Email'></a>

## UserCredential\.Email Property

Gets the email address of the user the credential belongs to\.

```csharp
public string? Email { get; private set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.User.Classes.UserCredential.PasswordHash'></a>

## UserCredential\.PasswordHash Property

Gets the Base64 encoded PBKDF2 derived key of the password\.

```csharp
public string? PasswordHash { get; private set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.User.Classes.UserCredential.PasswordIterations'></a>

## UserCredential\.PasswordIterations Property

Gets the number of PBKDF2 iterations the derived key was produced with\.

```csharp
public int PasswordIterations { get; private set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.User.Classes.UserCredential.PasswordSalt'></a>

## UserCredential\.PasswordSalt Property

Gets the Base64 encoded salt the derived key was produced with\.

```csharp
public string? PasswordSalt { get; private set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.User.Classes.UserLogin'></a>

## UserLogin Class

Represents the login credentials for a user, providing functionality for serialization and initialization from various sources\.

```csharp
public class UserLogin : DiGi.Core.Classes.SerializableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → UserLogin
### Constructors

<a name='DiGi.User.Classes.UserLogin.UserLogin(DiGi.User.Classes.UserLogin)'></a>

## UserLogin\(UserLogin\) Constructor

Initializes a new instance of the UserLogin class by copying another UserLogin object\.

```csharp
public UserLogin(DiGi.User.Classes.UserLogin userLogin);
```
#### Parameters

<a name='DiGi.User.Classes.UserLogin.UserLogin(DiGi.User.Classes.UserLogin).userLogin'></a>

`userLogin` [UserLogin](DiGi.User.Classes.md#DiGi.User.Classes.UserLogin 'DiGi\.User\.Classes\.UserLogin')

The source UserLogin object to copy from\.

<a name='DiGi.User.Classes.UserLogin.UserLogin(string)'></a>

## UserLogin\(string\) Constructor

Initializes a new instance of the UserLogin class with the specified email\.

```csharp
public UserLogin(string? email);
```
#### Parameters

<a name='DiGi.User.Classes.UserLogin.UserLogin(string).email'></a>

`email` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The email address of the user\.

<a name='DiGi.User.Classes.UserLogin.UserLogin(System.Text.Json.Nodes.JsonObject)'></a>

## UserLogin\(JsonObject\) Constructor

Initializes a new instance of the UserLogin class from a JsonObject\.

```csharp
public UserLogin(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.User.Classes.UserLogin.UserLogin(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing user login data\.
### Properties

<a name='DiGi.User.Classes.UserLogin.Email'></a>

## UserLogin\.Email Property

Gets the email address of the user\.

```csharp
public string? Email { get; private set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.User.Classes.UserLogin.Password'></a>

## UserLogin\.Password Property

Gets the password of the user\.

```csharp
public string? Password { get; private set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')