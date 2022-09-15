using SchoolDemo.Seeder;

namespace SchoolDemo;

public static class Program
{
    public static int Main(string[] args)
    {
        new BlogSeeder().Seed();
        return 0;
    }
}