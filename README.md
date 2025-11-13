# PointsBet Backend Online Code Test

## Changes Made
- Renamed `StringFormatter` to `ItemsFormatter` with `ToCommaSeparatedQuotedItems` method.
- Added unit tests in `PointsBet_Backend_Online_Code_Test.Tests` covering:
  - Valid inputs
  - Null or empty arrays
  - Null or empty quotes
  - Arrays containing null or empty items

## Dependencies
- .NET 7 SDK
- MSTest.TestFramework 3.2.10
- MSTest.TestAdapter 3.2.10

## Running Tests
```bash
dotnet test
