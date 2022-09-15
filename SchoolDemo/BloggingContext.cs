using Microsoft.EntityFrameworkCore;

namespace SchoolDemo;

public class BloggingContext : DbContext
{
    
    // Define Db sets
    public DbSet<Blog>? Blogs { get; set; }
    public DbSet<Post>? Posts { get; set; }
    
    private string DbPath { get; }

    public BloggingContext()
    {
        // Instantiate SqLite db for easier demo.
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "blogging.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlite($"Data Source ={DbPath}");
}