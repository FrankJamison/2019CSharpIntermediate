using System;
using System.Runtime.InteropServices;

namespace Exercise2_DesignAStackOverflowPost
{
    /*
     * Design a class called Post.
     * This class models a StackOverflow post.
     * It should have properties for title, description and the date/time it was created.
     * We should be able to up-vote or down-vote a post.
     * We should also be able to see the current vote value.
     * In the main method, create a post, up-vote and down-vote it a few times and then display the the current vote value.
     *
     * In this exercise, you will learn that a StackOverflow post should provide methods for up-voting and down-voting.
     * You should not give the ability to set the Vote property from the outside,
     * because otherwise, you may accidentally change the votes of a class to 0 or to a random number.
     * And this is how we create bugs in our programs.
     * The class should always protect its state and hide its implementation detail.
     */

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new post
            var post = new Post();

            // Get the post title from the user
            Console.WriteLine("Please enter a post title: ");
            post.title = Console.ReadLine();

            // Get the post description from the user
            Console.WriteLine("Please enter a post description: ");
            post.description = Console.ReadLine();

            // Add some votes (Total value = 3)
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.DownVote();
            post.UpVote();

            // Display Post Date
            Console.WriteLine("Post Title: {0}", post.title);
            Console.WriteLine("Post Description: {0}", post.description);
            Console.WriteLine("Post Date: {0}", post.date);
            Console.WriteLine("Post Votes: {0}", post.votes);
        }
    }
}
