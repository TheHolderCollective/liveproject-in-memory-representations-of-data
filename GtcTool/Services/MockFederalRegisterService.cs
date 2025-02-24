namespace Gtc.Services;
using Gtc.Models.FederalRegister;
class MockFederalRegisterService
{ //
    public Response GetFederalRegisterResponse()
    { //
        var document = new Document("Child and Adult Care Food...", "Notice", "This notice is", "2023-14317", "https://...", "https://...", "https://...", "2023-07-07", "This notice...");
        var agency = new Agency("DEPARMENT OF AGRICULTURE", "Agriculture Department", 12, "https://...", "https://", 12, "agriculture-department");
        document.Agencies.Add(agency);
        var response = new Response(48, "Documents with an effective date in 2023 and from Agriculture Department", 24, "https://...");
        response.Results.Add(document);
        return response;
    }
}