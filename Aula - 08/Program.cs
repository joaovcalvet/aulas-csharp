using Course.Entities;

namespace Course;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Instanciando os 'Posts'");
        Post post1 = new Post("Traveling to New Zealand", "I'm going to visit this wonderful country!", 12, DateTime.Parse("21/06/2018 13:05:44"));
        Post post2 = new Post("Good night guys", "See you tomorrow", 5, DateTime.Parse("28/07/2018 23:14:19"));

        Comment c1 = new Comment("Have a nice trip");
        Comment c2 = new Comment("Wow that's aweasome!");
        Comment c3 = new Comment("Good night");
        Comment c4 = new Comment("May the Force be with you");

        post1.AddComment(c1);
        post1.AddComment(c2);
        post2.AddComment(c3);
        post2.AddComment(c4);

        Console.WriteLine(post1 + "\n");
        Console.WriteLine(post2);
    }
}