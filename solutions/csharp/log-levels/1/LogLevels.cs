static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Split(':')[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        return logLine.Split('[', ']')[1].ToLower();
    }

    public static string Reformat(string logLine)
    {
        string[] split = logLine.Split('[', ']');
        return split[2].Substring(2).Trim() + " (" + split[1].ToLower().Trim() + ")"; 
    }
}
