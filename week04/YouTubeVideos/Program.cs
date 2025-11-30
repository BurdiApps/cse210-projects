using System;
using System.Collections.Generic;
using YouTubeVideos;

class Program
{
    static void Main(string[] args)
    {
        // Create sample videos
        var videos = new List<Video>
        {
            new Video("How to Cook Perfect Pasta", "Chef Bob", 540),
            new Video("DIY Desk Setup Tour", "TechieTina", 780),
            new Video("Beginner Yoga Flow", "WellnessWithJanet", 900),
            new Video("City Drone Cinematics", "SkyView Studios", 365)
        };

        // Add comments to each video (username-style authors)
        videos[0].AddComment(new Comment("sadcat34", "This helped me avoid soggy pasta!"));
        videos[0].AddComment(new Comment("riley_works", "Love the tip about salting water."));
        videos[0].AddComment(new Comment("priya.codes", "Tried it—worked perfectly."));

        videos[1].AddComment(new Comment("jordanDIY", "Clean aesthetic—where’s the monitor arm from?"));
        videos[1].AddComment(new Comment("caseyCable", "Cable management is on point."));
        videos[1].AddComment(new Comment("tay_setup", "Inspired to redo my setup!"));

        videos[2].AddComment(new Comment("morganMoves", "Perfect routine for beginners."));
        videos[2].AddComment(new Comment("lee_balance", "Feeling so relaxed now."));
        videos[2].AddComment(new Comment("ava_flow20", "Please make a 20-min version."));

        videos[3].AddComment(new Comment("noah_drone", "The transitions are so smooth."));
        videos[3].AddComment(new Comment("quinnSky", "What drone did you use?"));
        videos[3].AddComment(new Comment("zoeSunset", "Loved the sunset shots!"));

        // Display each video and its comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length (sec): {video.LengthSeconds}");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.Author}: {comment.Text}");
            }

            Console.WriteLine(new string('-', 50));
        }
    }
}