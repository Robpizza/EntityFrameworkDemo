using SchoolDemo.Models;

namespace SchoolDemo.Seeder;

public class PostSeeder
{
    /**
     * <summary>Used in <see cref="BlogSeeder"/></summary>
     */
    protected internal void Seed(ref Blog blog, int amount = 1)
    {
        using var db = new BloggingContext();
        for (var i = 0; i < amount; i++)
        {
            var post = new Post(Faker.Name.First(), Faker.Lorem.Paragraph(15), blog.BlogId);
            blog.Posts.Add(post);
        }
    }
}