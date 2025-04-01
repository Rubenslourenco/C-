using projetoPost.Entities;
using System;

namespace projetoPost
{
    class Program
    {
        static void Main(string[] args)
        {

            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome");
            Post p1 = new Post(
                DateTime.Parse("21/06/2024 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12
            );

            p1.AddComment(c1);
            p1.AddComment(c2);



            Comment c3 = new Comment("Good Nigth");
            Comment c4 = new Comment("MAy the Force be with you");
            Post p2 = new Post(
                DateTime.Parse("28/07/2024 13:05:44"),
                "Good Nigth Guys",
                "MAy the Force be with you",
                5
            );

            p2.AddComment(c3);
            p2.AddComment(c4);


            Console.WriteLine(p1);
            Console.WriteLine(p2);




        }
    }
}