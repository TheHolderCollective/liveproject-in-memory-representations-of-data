namespace Gtc.Models.FederalRegister;

public class Response
{ //
    public Response(int count, string description, int totalPages, string nextPageUrl)
    { //
        this.Count = count;
        this.Description = description;
        this.TotalPages = totalPages;
        this.NextPageUrl = nextPageUrl;
        this.Results = new List<Document>();
    }
    public int Count { get; set; }
    public string Description { get; set; }
    public int TotalPages { get; set; }
    public string NextPageUrl { get; set; }
    public List<Document> Results { get; set; }

    public override string ToString()
    { //
        return $"#Response\nCount: {Count}\nDescription: {Description}\nTotalPages: {TotalPages}\nNextPageUrl: {NextPageUrl}\nResults: {Results.ListToString()}";
    }
}