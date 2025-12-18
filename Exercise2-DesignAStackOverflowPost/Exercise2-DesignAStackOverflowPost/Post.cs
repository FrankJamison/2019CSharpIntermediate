using System;

namespace Exercise2_DesignAStackOverflowPost
{
    class Post
    {
        public string title { get; set; }
        public string description { get; set; }
        public DateTime date { get; private set; }
        public int votes { get; private set; }

        /*
         * --- Constructor ---
         * Used to set the post creation date and time
         */
        public Post()
        {
            date = DateTime.Now;
        }

        /*
         * --- UpVote ---
         * Used to increase the vote
         */
        public void UpVote()
        {
            votes += 1;
        }

        /*
         * --- DownVote ---
         * Used to decrease the vote
         */
        public void DownVote()
        {
            votes -= 1;
        }
    }
}