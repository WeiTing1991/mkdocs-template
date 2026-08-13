# C# API Reference

Auto-generated from XML documentation comments using [MkDoxy](https://mkdoxy.kubaandrysek.cz/) (Doxygen).

!!! note "Doxygen Required"
    Full API generation requires [Doxygen](https://www.doxygen.nl/download.html) installed.
    Run `uv run mkdocs build` to generate the complete Doxygen output.

## Namespace: Example

### `MathUtils`

```csharp
/// <summary>A simple math utility class.</summary>
public static class MathUtils
{
    public static int Add(int a, int b);
    public static double Multiply(double a, double b);
}
```

| Method | Description |
|--------|-------------|
| `Add(int a, int b)` | Add two integers |
| `Multiply(double a, double b)` | Multiply two doubles |

### `Calculator`

```csharp
/// <summary>A simple calculator class that tracks a running result.</summary>
public class Calculator
{
    public Calculator();
    public double Add(double value);
    public double Result { get; }
    public void Reset();
}
```

| Member | Description |
|--------|-------------|
| `Calculator()` | Initialize with result set to zero |
| `Add(double value)` | Add a value to the running result |
| `Result` | Get the current result |
| `Reset()` | Reset the calculator to zero |
