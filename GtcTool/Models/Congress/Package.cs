namespace Gtc.Models.Congress;

public record Package(string PackageId, DateTime LastModified, string PackageLink, string DocClass, 
                     string Title, string Congress, DateTime DateIssued);

