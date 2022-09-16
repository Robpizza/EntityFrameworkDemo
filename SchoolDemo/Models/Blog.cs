namespace SchoolDemo.Models;

public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }

    public Author? Authors { get; set; }

    public virtual List<Post> Posts { get; } = new();

    public Blog(string url)
    {
        Url = url;
    }
}