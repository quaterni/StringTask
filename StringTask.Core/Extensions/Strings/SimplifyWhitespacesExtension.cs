
using StringTask.Core.Exceptions;
using System.Text.RegularExpressions;

namespace StringTask.Core.Extensions.Strings;

public static class SimplifyWhitespacesExtension
{
    // Readable method naming
    public static string SimplifyWhitespaces(this string str)
    {
        if(str.Equals(string.Empty))
        {
            throw new EmptyStringException();
        }

        const string pattern = @"(\s|&nbsp;)+";
        const string replacement = " ";

        var result = Regex.Replace(str, pattern, replacement);

        return result;
    }

    // Task method naming
    public static string Fn(this string str)
    {
        return str.SimplifyWhitespaces();
    }
}
