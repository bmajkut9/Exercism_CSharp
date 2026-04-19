public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string message, string stringAfter) => message.Substring(message.IndexOf(stringAfter) + stringAfter.Length);
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string message, string before, string after) => message.Substring(message.IndexOf(before) + before.Length, message.IndexOf(after) - (message.IndexOf(before) + before.Length));
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string message) => message.SubstringAfter(": ");
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string message) => message.SubstringBetween("[", "]");
}