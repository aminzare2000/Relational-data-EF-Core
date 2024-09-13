namespace RelationalDataEFCore.Models;

public class Organ
{
    public int Id { get; set; }

    public string UniversityName { get; set; } = string.Empty;

    public string? Departemant { get; set; }
    public string? Group { get; set; }

    public ICollection<Author>? Authors { get; set; }

}