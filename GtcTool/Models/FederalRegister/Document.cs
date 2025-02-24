namespace Gtc.Models.FederalRegister;

public class Document
{ //
    public Document(string title, string type, string @abstract, string documentNumber, string htmlUrl, string pdfUrl, string publicInspectionPdfUrl, string publicationDate, string excerpts)
    { //
        Title = title;
        Type = type;
        Abstract = @abstract;
        DocumentNumber = documentNumber;
        HtmlUrl = htmlUrl;
        PdfUrl = pdfUrl;
        PublicInspectionPdfUrl = publicInspectionPdfUrl;
        PublicationDate = publicationDate;
        Agencies = new List<Agency>();
        Excerpts = excerpts;
    }
    public string Title { get; set; }
    public string Type { get; set; }
    public string Abstract { get; set; }
    public string DocumentNumber { get; set; }
    public string HtmlUrl { get; set; }
    public string PdfUrl { get; set; }
    public string PublicInspectionPdfUrl { get; set; }
    public string PublicationDate { get; set; }
    public List<Agency> Agencies { get; set; }
    public string Excerpts { get; set; }

    public override string ToString()
    { //
        var agencies = this.GetAgencies();
        return $"##Document\nTitle: {Title}\nType: {Type}\nAbstract: {Abstract}\nDocumentNumber: {DocumentNumber}\nHtmlUrl: {HtmlUrl}\nPdfUrl: {PdfUrl}\nPublicInspectionPdfUrl: {PublicInspectionPdfUrl}\nPublicationDate: {PublicationDate}\nAgencies: {agencies}\nExcerpts: {Excerpts}";
    }

    private string GetAgencies()
    { //
        string agencies = "\n";
        foreach (var agency in Agencies)
        { //
            agencies += agency.ToString() + "\n";
        }
        return agencies;
    }
}