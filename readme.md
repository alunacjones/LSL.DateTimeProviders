[![Build status](https://img.shields.io/appveyor/ci/alunacjones/lsl-datetimeproviders.svg)](https://ci.appveyor.com/project/alunacjones/lsl-datetimeproviders)
[![Coveralls branch](https://img.shields.io/coverallsCoverage/github/alunacjones/LSL.DateTimeProviders)](https://coveralls.io/github/alunacjones/LSL.DateTimeProviders)
[![NuGet](https://img.shields.io/nuget/v/LSL.DateTimeProviders.svg)](https://www.nuget.org/packages/LSL.DateTimeProviders/)

# LSL.DateTimeProviders

Some basic abtractions over `DateTime` and `DateTimeOffset` for easier unit testing.

## IDateTimeProvider

This has one method called `Now` to return `DateTime.Now` in the default implementation

```csharp
// Get now using the default impementation

var now = new DateTimeProvider().Now();
```

## IDateTimeOffsetProvider

This has one method called `Now` to return `DateTimeOffset.Now` in the default implementation

```csharp
// Get now using the default impementation

var now = new DateTimeOffsetProvider().Now();
```



