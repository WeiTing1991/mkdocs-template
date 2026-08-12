"""Example Python module for documentation demo."""


def add(a: int, b: int) -> int:
    """Add two numbers.

    Args:
        a: First number.
        b: Second number.

    Returns:
        The sum of a and b.
    """
    return a + b


def greet(name: str) -> str:
    """Generate a greeting message.

    Args:
        name: The name to greet.

    Returns:
        A greeting string.
    """
    return f"Hello, {name}!"


class Calculator:
    """A simple calculator class.

    Attributes:
        history: List of past calculation results.
    """

    def __init__(self) -> None:
        """Initialize the calculator with empty history."""
        self.history: list[float] = []

    def multiply(self, a: float, b: float) -> float:
        """Multiply two numbers and store the result.

        Args:
            a: First number.
            b: Second number.

        Returns:
            The product of a and b.
        """
        result = a * b
        self.history.append(result)
        return result
