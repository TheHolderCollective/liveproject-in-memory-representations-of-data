namespace Gtc.Utils;
using System.Text.Json;
using System.Text;

public class SnakeCaseNamingPolicy : JsonNamingPolicy
{ //
    public override string ConvertName(string name)
    { //
        if (string.IsNullOrEmpty(name))
            return name;

        var builder = new StringBuilder(name.Length + Math.Min(2, name.Length / 5));
        bool addUnderscore = false;

        foreach (char c in name)
        { //
            if (char.IsUpper(c))
            { //
                if (addUnderscore)
                    builder.Append('_');

                builder.Append(char.ToLowerInvariant(c));
            }
            else
            { //
                builder.Append(c);
                addUnderscore = true;
            }
        }

        return builder.ToString();
    }
}