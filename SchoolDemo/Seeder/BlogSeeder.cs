namespace SchoolDemo.Seeder;

public class BlogSeeder
{
    private const int Amount = 150;

    protected internal void Seed()
    {
        using var db = new BloggingContext();
        for (var i = 0; i < Amount; i++)
        {
            var blog = new Blog(Faker.Internet.Url());
            Console.Out.WriteLine($"Blog inserted with url: {blog.Url}");
            Console.Out.WriteLine($"Generating random amount of posts");
           
            new PostSeeder().Seed(ref blog, new Random().Next(1, 5));
            
            db.Blogs.Add(blog);
            db.SaveChanges();
        }
    }
}