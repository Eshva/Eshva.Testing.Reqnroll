Useful utils for .NET BDD framework [Reqnroll](https://github.com/reqnroll/Reqnroll) (a fork of SpecFlow)

# Installation and usage

Install the package from NuGet:

```shell
dotnet add package Eshva.Testing.Reqnroll
```

Or via the NuGet Package Manager:

```shell
Install-Package Eshva.Testing.Reqnroll
```

Or via appropriate window in Rider or Visual Studio.

Then place in the root of your test project folder a file named
`reqnroll.json` ([more info about Reqnroll configuration](https://docs.reqnroll.net/latest/installation/configuration.html)),
if you don't have it yet, and add into it the following `bindingAssemblies` section:

```json
{
  "$schema": "https://schemas.reqnroll.net/reqnroll-config-latest.json",
  "bindingAssemblies": [
    {
      "assembly": "Eshva.Testing.Reqnroll"
    }
  ]
}
```

# Steps argument transformations

## Date-time offset transformation

Transforms original string value given in `dd.MM.yyyy HH:mm:ss` format into `DateTimeOffset` at UTC. Supports the
following special values:

- `<min>` — `DateTimeOffset.MinValue`,
- `<max>` — `DateTimeOffset.MaxValue`.

## Nullable date-time offset transformation

Transforms original string value given in `dd.MM.yyyy HH:mm:ss` format into `DateTimeOffset` at UTC. Supports the
following special values:

- `<min>` — `DateTimeOffset.MinValue`,
- `<max>` — `DateTimeOffset.MaxValue`,
- `<null>` — `null`,
- `null` — `null`.

## Nullable time span transformation

Transforms original string value into `TimeSpan`. Supports the following special values:

- `<min>` — `TimeSpan.MinValue`,
- `<max>` — `TimeSpan.MaxValue`,
- `<null>` — `null`,
- `null` — `null`.

## Nullable string transformation

Returns original string value or on of the following special values:

- `<empty>` — `string.Empty`,
- `<whitespace>` — `\r\n \t`,
- `<null>` — `null`,
- `null` — `null`.

## Nullable string array, list and readonly list transformations

Parses original string value into list of string items. Items should be separated with comma or semicolon. Leading and
trailing white-spaces characters ara trimmed. Supports the following special values:

- `<empty>` — empty list,
- `<null>` — `null`,
- `null` — `null`.

## Nullable signed and unsigned number transformations

Parses original string value into one of: `sbyte`, `byte`, `short`, `ushourt`, `int`, `uint`, `long`, `ulong`. Supports
the following special values:

- `<min>` — number type minimum value,
- `<max>` — number type maximum value,
- `<null>` — `null`,
- `null` — `null`.
