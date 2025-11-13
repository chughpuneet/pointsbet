# PointsBet Backend Online Code Test – Refactored Solution

## Overview
This submission includes a refactored and improved version of the original `StringFormatter` class provided in the exercise.  
 
## Improvements Made

- Renamed class to **`StringCollectionFormatter`** for clearer meaning and responsibility.
- Added **input validation** to safely handle null, empty, and invalid values.
- Replaced manual loops and `StringBuilder`.
- Empty or null items inside the array are **ignored** to prevent malformed output.
- Improved formatting using **string interpolation**.
- Converted class to a **static helper class**, as it contains only pure formatting logic.

## Dependencies

- **.NET 7.0** (main library project)
- **MSTest** (`Microsoft.NET.Test.Sdk`, `MSTest.TestAdapter`, `MSTest.TestFramework`) for unit testing
- No additional external packages required.

## Unit Tests

The unit test suite validates:

- Formatting with different quote characters (`"`, `'`, `*`, etc.)
- Proper behavior when items or quote values are null or empty.
- Ignoring null or empty elements within the input array.
- Correct output with multiple valid items.

This ensures that the formatter behaves consistently across all typical and edge-case scenarios.

## How to Run Tests

From the solution directory:

```bash
dotnet test
