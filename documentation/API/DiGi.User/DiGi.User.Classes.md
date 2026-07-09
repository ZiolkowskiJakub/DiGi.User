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