using RelationalDataEFCore.Models;

namespace RelationalDataEFCore.Models;

public class Journal
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? ISSN { get; set; }

    public string? Owner { get; set; }

    public ICollection<NumberIssue>? NumberIssues { get; set; }

}