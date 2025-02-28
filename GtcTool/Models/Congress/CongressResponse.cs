namespace Gtc.Models.Congress;

public record CongressResponse(int Count, string Message, string NextPage, string PreviousPage,
                               List<Package> Packages)
{
    public override string ToString()
    {
        return $"#CongressResponse\nCount: {Count}\nMessage: {Message}\nNextPage: {NextPage}\nPreviousPage: {PreviousPage}\nPackages: {Packages.ListToString()}";
    }
}
