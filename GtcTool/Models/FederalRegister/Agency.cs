namespace Gtc.Models.FederalRegister;

public class Agency
{ //
    public Agency(string rawName, string name, int id, string url, string jsonUrl, int? parentId, string slug)
    { //
        RawName = rawName;
        Name = name;
        Id = id;
        Url = url;
        JsonUrl = jsonUrl;
        ParentId = parentId;
        Slug = slug;
    }
    public string RawName { get; set; }
    public string Name { get; set; }
    public int Id { get; set; }
    public string Url { get; set; }
    public string JsonUrl { get; set; }
    public int? ParentId { get; set; }
    public string Slug { get; set; }

    public override string ToString()
    { //
        return $"###Agency\nRawName: {RawName}\nName: {Name}\nId: {Id}\nUrl: {Url}\nJsonUrl: {JsonUrl}\nParentId: {ParentId}\nSlug: {Slug}";
    }

}