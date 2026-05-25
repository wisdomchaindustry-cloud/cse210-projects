using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video(
            "Learn C# Basics",
            "CodeMaster",
            600
        );

        video1.AddComment(new Comment(
            "Francis",
            "Very helpful tutorial!"
        ));

        video1.AddComment(new Comment(
            "John",
            "I finally understand classes."
        ));

        video1.AddComment(new Comment(
            "Sarah",
            "Great explanation!"
        ));

        Video video2 = new Video(
            "ASP.NET Core Guide",
            "TechWorld",
            1200
        );

        video2.AddComment(new Comment(
            "Daniel",
            "Excellent content."
        ));

        video2.AddComment(new Comment(
            "Grace",
            "Please make more videos."
        ));

        video2.AddComment(new Comment(
            "Mike",
            "This saved my project."
        ));

        Video video3 = new Video(
            "Firebase Authentication",
            "WebCafe AI",
            850
        );

        video3.AddComment(new Comment(
            "Emma",
            "Authentication is now easy."
        ));

        video3.AddComment(new Comment(
            "Victor",
            "Thanks for the clear steps."
        ));

        video3.AddComment(new Comment(
            "Sophia",
            "Best tutorial so far."
        ));

        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3
        };

        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}