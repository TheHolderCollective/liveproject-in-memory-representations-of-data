using Gtc.Models.Congress;
using Gtc.Models.FederalRegister;
using System.Text.Json;
namespace Gtc.Services;

public class CongressService
{
    private string endPointUrl;
    public CongressService(SecretConfigReader secretConfigReader)
    {
        var apiKey = secretConfigReader.ReadSection<SecretValues>("Gtc").ApiKey;
        endPointUrl = "https://api.govinfo.gov/collections/BILLS/2023-01-28T20%3A18%3A10Z?offset=0&pageSize=20&api_key=" + apiKey;
       // Console.WriteLine(endPointUrl);
    }

    public async Task<(CongressResponse? response, List<Package> packages)> GetCongressResponseWithPackagesAsync()
    {

        var responseObject = await this.GetCongressResponseAsync();
        var specificPackages = this.GetSpecificPakages(responseObject);
        var tuple = (responseObject, specificPackages);
        return tuple;

    }

    public async Task<CongressResponse?> GetCongressResponseAsync()
    {
        var congressResponseContent = await this.GetCongressResponseJsonAsync();
        var serializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        var congressResponseObject = congressResponseContent != null ? JsonSerializer.Deserialize<CongressResponse>(congressResponseContent, options: serializerOptions) : null;
        return congressResponseObject;
    }
    protected async Task<string?> GetCongressResponseJsonAsync()
    {
        var httpClient = new HttpClient();
        var response = await httpClient.GetAsync(endPointUrl);
        var responseContent = await response.Content.ReadAsStringAsync();

        return responseContent;
    }


    private List<Package> GetSpecificPakages(CongressResponse baseResponse)
    {
        var listOfInterestWords = new[] { "agric", "water", "plant"};
        var filteredList = new List<Package>();

        foreach (var package in baseResponse.Packages)
        {
            foreach (var interestWord in listOfInterestWords)
            {
                if (package.Title.ToLowerInvariant().Contains(interestWord))
                {
                    filteredList.Add(package);
                }
            }
        }
        return filteredList;

    }
}
