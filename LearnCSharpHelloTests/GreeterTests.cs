using LearnCSharpHello;
using Xunit;

namespace LearnCSharpHelloTests;

public class GreeterTests
{
    private readonly Greeter _greeter = new();

    [Fact]
    public void Greet_ReturnsHelloWithName()
    {
        Assert.Equal("Hello, World!", _greeter.Greet("World"));
    }

    [Theory]
    [InlineData("Alice", "Hello, Alice!")]
    [InlineData("Bob", "Hello, Bob!")]
    [InlineData("C#", "Hello, C#!")]
    public void Greet_ReturnsCorrectGreeting(string name, string expected)
    {
        Assert.Equal(expected, _greeter.Greet(name));
    }
}
