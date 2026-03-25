using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Classes for Beginners", "Code Academy", 420);
        video1.AddComment(new Comment("Alice", "This explanation was really clear."));
        video1.AddComment(new Comment("Bruno", "Now I finally understand classes."));
        video1.AddComment(new Comment("Carla", "Great examples, thanks!"));
        video1.AddComment(new Comment("Daniel", "Please make one about inheritance."));
        videos.Add(video1);

        Video video2 = new Video("Top 10 Study Tips", "Student Success", 300);
        video2.AddComment(new Comment("Emma", "These tips are very helpful."));
        video2.AddComment(new Comment("Felipe", "I will try the time blocking idea."));
        video2.AddComment(new Comment("Giovana", "Nice video and easy to follow."));
        videos.Add(video2);

        Video video3 = new Video("Healthy Morning Routine", "Life Balance", 515);
        video3.AddComment(new Comment("Hugo", "I need to improve my mornings."));
        video3.AddComment(new Comment("Isabela", "The advice about sleep was great."));
        video3.AddComment(new Comment("João", "Simple and motivating."));
        video3.AddComment(new Comment("Karen", "I started doing this routine too."));
        videos.Add(video3);

        Video video4 = new Video("How to Build a Portfolio", "Dev Career", 610);
        video4.AddComment(new Comment("Lucas", "This helped me a lot."));
        video4.AddComment(new Comment("Marina", "Very useful for junior developers."));
        video4.AddComment(new Comment("Nicolas", "Can you make a resume video next?"));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length (seconds): {video.LengthInSeconds}");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}