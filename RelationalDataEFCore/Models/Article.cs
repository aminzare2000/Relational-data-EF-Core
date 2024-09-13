using RelationalDataEFCore.Models;

namespace RelationalDataEFCore.Models;

public class Article
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Abstract { get; set; }
    public string? Keywords { get; set; }

    public required NumberIssue NumberIssue { get; set; }

    public ICollection<Author>? Authors { get; set; }
}