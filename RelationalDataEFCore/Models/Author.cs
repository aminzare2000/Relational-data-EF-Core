namespace RelationalDataEFCore.Models;

public class Author
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Family { get; set; }

    public ICollection<Article>? Articles { get; set; }

    public ICollection<Organ>? Organs { get; set; }

}