#### [DiGi\.User](DiGi.User.Overview.md 'DiGi\.User\.Overview')

## DiGi\.User\.Enums Namespace
### Enums

<a name='DiGi.User.Enums.UserLevel'></a>

## UserLevel Enum

Represents the permission levels for user access control\.
Higher values grant more privileges\. Gaps between values allow intermediate levels to be inserted without renumbering\.

```csharp
public enum UserLevel
```
### Fields

<a name='DiGi.User.Enums.UserLevel.Guest'></a>

`Guest` 0

Guest — no account, zero access\.

<a name='DiGi.User.Enums.UserLevel.User'></a>

`User` 10

User — authenticated, standard features\.

<a name='DiGi.User.Enums.UserLevel.Admin'></a>

`Admin` 100

Admin — manage users, edit configuration, moderate content\.

<a name='DiGi.User.Enums.UserLevel.Owner'></a>

`Owner` 1000

Owner — full system control, destructive or irreversible operations\.