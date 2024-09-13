using RelationalDataEFCore.Models;

namespace RelationalDataEFCore.Models;

public class NumberIssue
{
    public int Id { get; set; }

    public string? PublishYear { get; set; }

    public int? Number { get; set; }
    public int? Issue { get; set; }

    public required Journal Journal { get; set; }

    public ICollection<Article>? Articles { get; set; }

}