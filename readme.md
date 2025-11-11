Useful utilities for testing with BDD framework [Reqnroll](https://github.com/reqnroll/Reqnroll) (a fork of SpecFlow).

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
if you don't have it yet, and add into it the following `bindingAssemblies` [section](https://docs.reqnroll.net/latest/installation/configuration.html#bindingassemblies):

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

# Contexts and steps

## Error handling context

Error handling context, and it's associated steps could be used to centralize error handling. To use it get `ErrorHandlingContext` instance in your steps classes like this:
```csharp
public GetEntrySteps(ErrorHandlingContext errorHandlingContext) {
  _errorHandlingContext = errorHandlingContext;
}
```

After that you should publish to this context caught exception:
```csharp
[When("I get (.*) cache entry asynchronously")]
public async Task WhenIGetCacheEntry(string key) {
  try {
    _cachesContext.GottenCacheEntryValue = await _cachesContext.Cache.GetAsync(key).ConfigureAwait(continueOnCapturedContext: false);
  }
  catch (Exception exception) {
    _errorHandlingContext.LastException = exception;
  }
}
```

In your feature-files you can use the following steps:
- Then no errors are reported
- Then not supported error should be reported
- Then argument not specified error should be reported
- Then argument out of range error should be reported
- Then invalid operation error should be reported

Or their Russian versions:
- Тогда не должно быть получено никаких ошибок
- Тогда я должен получить ошибку неподдерживаемой операции
- Тогда я должен получить ошибку о неопределённом аргументе
- Тогда я должен получить ошибку о выходе значения за допустимые границы
- Тогда я должен получить ошибку о недопустимой операции
