using SchoolDemo.Seeder;

namespace SchoolDemo;

public static class Program
{
    public static int Main(string[] args)
    {
        new AuthorSeeder().Seed();
        return 0;
    }
}