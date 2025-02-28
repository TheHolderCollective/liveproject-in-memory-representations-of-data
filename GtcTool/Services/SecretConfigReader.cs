using Microsoft.Extensions.Configuration;
public class SecretConfigReader
{
    public T? ReadSection<T>(string sectionName)
    {
        var environment = Environment.GetEnvironmentVariable("NETCORE_ENVIRONMENT");
        var builder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true)
            .AddJsonFile($"appsettings.{environment}.json", optional: true)
            .AddUserSecrets<Program>()
            .AddEnvironmentVariables();
        var configurationRoot = builder.Build();
        if (configurationRoot == null) return default;

        var section = configurationRoot!.GetSection(sectionName);
        return section.Get<T>() ?? default;
    }
}
