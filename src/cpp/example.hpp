#pragma once

/// @file example.hpp
/// @brief Example C++ header for documentation demo.

/// @brief A simple math namespace.
namespace math {

/// @brief Add two integers.
/// @param a First number.
/// @param b Second number.
/// @return The sum of a and b.
int add(int a, int b) {
    return a + b;
}

/// @brief Multiply two doubles.
/// @param a First number.
/// @param b Second number.
/// @return The product of a and b.
double multiply(double a, double b) {
    return a * b;
}

/// @brief A simple calculator class.
class Calculator {
public:
    /// @brief Create a new Calculator.
    Calculator() : result_(0.0) {}

    /// @brief Add a value to the running result.
    /// @param value The value to add.
    /// @return The updated result.
    double add(double value) {
        result_ += value;
        return result_;
    }

    /// @brief Get the current result.
    /// @return The current accumulated result.
    double result() const {
        return result_;
    }

    /// @brief Reset the calculator to zero.
    void reset() {
        result_ = 0.0;
    }

private:
    double result_; ///< The accumulated result.
};

} // namespace math
