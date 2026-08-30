[![](https://img.shields.io/nuget/v/soenneker.enums.statetype.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.statetype/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.statetype/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.statetype/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.enums.statetype.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.statetype/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.statetype/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.statetype/actions/workflows/codeql.yml)

# Soenneker.Enums.StateType

A smart enum for the 50 U.S. states, the District of Columbia, and Puerto Rico, with postal abbreviations and display names.

## Install

```bash
dotnet add package Soenneker.Enums.StateType
```

## Usage

```csharp
using Soenneker.Enums.StateType;

StateType state = StateType.NewYork;

string name = state.Name;                 // "NewYork"
int value = state.Value;                  // 32
string abbreviation = state.Abbreviation; // "NY"
string displayName = state.Description;   // "New York"
```

Look up a value by postal abbreviation:

```csharp
StateType texas = StateType.FromAbbreviation("TX");

if (StateType.TryFromAbbreviation(input, ignoreCase: true, out StateType? parsed))
{
    Console.WriteLine(parsed.Description);
}
```

Abbreviation lookup is case-insensitive for this type. `FromAbbreviation` throws when no value matches; use `TryFromAbbreviation` for user input.

The inherited smart-enum APIs also support names, numeric values, and enumeration:

```csharp
StateType district = StateType.FromName("DistrictOfColumbia");
StateType puertoRico = StateType.FromValue(39);

foreach (StateType option in StateType.List)
    Console.WriteLine($"{option.Abbreviation}: {option.Description}");
```

Use `Abbreviation` for postal and external contracts. The numeric `Value` is a package identifier, not a postal or FIPS code.

The set includes DC and Puerto Rico but not other U.S. territories, military postal regions, or freely associated states. It identifies a region only; it does not validate an address, ZIP code, state/ZIP relationship, or deliverability.
