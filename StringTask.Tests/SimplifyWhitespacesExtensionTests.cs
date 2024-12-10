
using StringTask.Core.Exceptions;
using StringTask.Core.Extensions.Strings;
using Xunit;

namespace StringTask.Tests;

public class SimplifyWhitespacesExtensionTests
{
    [Theory]
    [InlineData("abc", "abc")]
    [InlineData("a b", "a b")]
    [InlineData("a  b", "a b")]
    [InlineData("a   b", "a b")]
    [InlineData("a b с", "a b с")]
    [InlineData("a  b  с", "a b с")]
    [InlineData("a   b   с", "a b с")]
    [InlineData("a \u00a0b", "a b")]
    [InlineData("a \u00a0\t\r\nb", "a b")]
    [InlineData("a&nbsp;b", "a b")]
    [InlineData("a &nbsp;b", "a b")]
    [InlineData("a &nbsp;&nbsp;b", "a b")]
    [InlineData("a \u00a0\t\r\n&nbsp;&nbsp;b", "a b")]
    public void SimplifyWhitespacesShould_SimplifyString(string rawString, string expected)
    {
        var result = rawString.SimplifyWhitespaces();

        Assert.Equal(expected, result);
    }

    [Fact]
    public void SimplifyWhitespacesShould_ShouldThrowEmptyStringException_IfStringEmpty()
    {
        Assert.Throws<EmptyStringException>(string.Empty.SimplifyWhitespaces);
    }
}
