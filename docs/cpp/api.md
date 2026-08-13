# C++ API Reference

Auto-generated from Doxygen comments using [MkDoxy](https://mkdoxy.kubaandrysek.cz/).

!!! note "Doxygen Required"
    Full API generation requires [Doxygen](https://www.doxygen.nl/download.html) installed.
    Run `uv run mkdocs build` to generate the complete Doxygen output.

## Namespace: math

### `math::add`

```cpp
/// @brief Add two integers.
/// @param a First number.
/// @param b Second number.
/// @return The sum of a and b.
int add(int a, int b);
```

### `math::multiply`

```cpp
/// @brief Multiply two doubles.
/// @param a First number.
/// @param b Second number.
/// @return The product of a and b.
double multiply(double a, double b);
```

### `math::Calculator`

```cpp
/// @brief A simple calculator class.
class Calculator {
public:
    Calculator();
    double add(double value);
    double result() const;
    void reset();
};
```

| Method | Description |
|--------|-------------|
| `Calculator()` | Create a new Calculator |
| `add(double value)` | Add a value to the running result |
| `result()` | Get the current accumulated result |
| `reset()` | Reset the calculator to zero |
