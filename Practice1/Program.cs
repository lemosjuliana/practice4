using System;

namespace Practice1
{
    class Program
    {
        static public List<Video> _videos;

        static void Main(string[] args)
        {
            _videos = new List<Video>();

            Video video1 = new Video("2022 First Presidency's Christmas Devotional",
                                     "The Church of Jesus Christ of Latter-day Saints", 5200);
            Video video2 = new Video("The Promise of Christmas",
                                     "The Church of Jesus Christ of Latter-day Saints", 3400);
            Video video3 = new Video("Joseph Smith: The Prophet of the Restoration",
                                     "The Church of Jesus Christ of Latter-day Saints", 3600);

            video1.AddComment(new Comment("Juliana", "I loved the video!"));
            video1.AddComment(new Comment("Mauricio", "Very inspiring!"));
            video1.AddComment(new Comment("Filipe", "How can I share the video?"));

            video2.AddComment(new Comment("Iraildes", "Thanks for the performance"));
            video2.AddComment(new Comment("Daniel", "This video made me stronger. Congrats to the Tabernacle Choir"));
            video2.AddComment(new Comment("Cecilia", "Great!"));

            video3.AddComment(new Comment("Paulo", "I love this Gospel!"));
            video3.AddComment(new Comment("Robert", "I would like to learn more about the Church. Do you guys have any suggestions"));
            video3.AddComment(new Comment("Breno", "I love to learn about Joseph Smith"));

            _videos.Add(video1);
            _videos.Add(video2);
            _videos.Add(video3);

            // interar pela lista
            // retorna um video

            Console.WriteLine("***************** AVAILABLE VIDEOS **********************");
            foreach (var video in _videos)
            {
                Console.WriteLine("-" + video.GetTitle());
                Console.WriteLine("*******************   COMMENTS  **********************");
                foreach(var comment in video.GetComments())
                {
                    Console.WriteLine("Author: " + comment.GetNameComment() + " Comment: " + comment.GetTextComment());
                }
            }

            // foreach (Video video in _videos)
            // {

            // }

        }
    }
}
