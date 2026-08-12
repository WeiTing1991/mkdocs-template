/// <summary>
/// Example C# class for documentation demo.
/// </summary>
namespace Example
{
    /// <summary>
    /// A simple math utility class.
    /// </summary>
    public static class MathUtils
    {
        /// <summary>
        /// Add two integers.
        /// </summary>
        /// <param name="a">First number.</param>
        /// <param name="b">Second number.</param>
        /// <returns>The sum of a and b.</returns>
        public static int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Multiply two doubles.
        /// </summary>
        /// <param name="a">First number.</param>
        /// <param name="b">Second number.</param>
        /// <returns>The product of a and b.</returns>
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
    }

    /// <summary>
    /// A simple calculator class that tracks a running result.
    /// </summary>
    public class Calculator
    {
        private double _result;

        /// <summary>
        /// Initializes a new Calculator with result set to zero.
        /// </summary>
        public Calculator()
        {
            _result = 0.0;
        }

        /// <summary>
        /// Add a value to the running result.
        /// </summary>
        /// <param name="value">The value to add.</param>
        /// <returns>The updated result.</returns>
        public double Add(double value)
        {
            _result += value;
            return _result;
        }

        /// <summary>
        /// Get the current result.
        /// </summary>
        public double Result => _result;

        /// <summary>
        /// Reset the calculator to zero.
        /// </summary>
        public void Reset()
        {
            _result = 0.0;
        }
    }
}
