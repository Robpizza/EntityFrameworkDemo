using SchoolDemo.Models;

namespace SchoolDemo;

public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }

    public virtual List<Post> Posts { get; } = new();

    public Blog(string url)
    {
        Url = url;
    }
}