using Gtc.Models.FederalRegister;
using Gtc.Utils;
using System.Text.Json;
namespace Gtc.Services;

public class FederalRegisterService
{ //
    public async Task<Response?> GetResponseAsync()
    { //
        var responseContent = await this.GetResponseJsonAsync();
        var serializerOptions = new JsonSerializerOptions
        { //
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = new SnakeCaseNamingPolicy()
        };
        var responseObject = responseContent != null ? JsonSerializer.Deserialize<Response>(responseContent, options: serializerOptions) : null;
        return responseObject;
    }

    protected virtual async Task<string?> GetResponseJsonAsync()
    { //
        var client = new HttpClient();
        var response = await client.GetAsync("https://www.federalregister.gov/api/v1/documents.json?conditions%5Beffective_date%5D%5Byear%5D=2023&conditions%5Bagencies%5D%5B%5D=agriculture-department");
        var responseContent = await response.Content.ReadAsStringAsync();
        return responseContent;
    }
}