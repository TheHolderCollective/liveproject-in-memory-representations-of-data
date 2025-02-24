namespace Gtc.Models;
using System.Collections.Generic;
using System.Text;

public static class ListExtensions
{
    public static string ListToString<T>(this IEnumerable<T> source) where T : class
    {
        var sb = new StringBuilder();
        sb.AppendLine();
        foreach (var result in source)
        {
            sb.AppendLine(result.ToString());
        }
        return sb.ToString();
    }
}
