namespace SchoolDemo.Models;

public class Author
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Author(string name)
    {
        Name = name;
    }
}