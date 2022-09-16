using SchoolDemo.Models;

namespace SchoolDemo.Seeder;

public class AuthorSeeder
{
    internal void Seed()
    {
        // Database context
        using var db = new BloggingContext();

        // Loop for creating and adding all the objects
        for (var i = 0; i < 24; i++)
        {
            var author = new Author(Faker.Name.First());
            db.Author.Add(author);
        }

        db.SaveChanges();
    }
}