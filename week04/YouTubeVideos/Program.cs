using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video();
        video1._title = "Best Budget Gaming Laptop Review";
        video1._author = "TechWorld";
        video1._length = 845;

        video1._comments.Add(new Comment { _commenterName = "Carlos", _text = "This review helped me choose my laptop." });
        video1._comments.Add(new Comment { _commenterName = "Emily", _text = "Great explanation of the specs." });
        video1._comments.Add(new Comment { _commenterName = "Nathan", _text = "I like how simple this was to understand." });

        videos.Add(video1);

        Video video2 = new Video();
        video2._title = "Easy Chilean Porotos Recipe";
        video2._author = "Cooking With Familia";
        video2._length = 620;

        video2._comments.Add(new Comment { _commenterName = "Maria", _text = "This reminds me of home." });
        video2._comments.Add(new Comment { _commenterName = "John", _text = "I tried this recipe and it was amazing." });
        video2._comments.Add(new Comment { _commenterName = "Sofia", _text = "Please make more Chilean recipes." });

        videos.Add(video2);

        Video video3 = new Video();
        video3._title = "How to Fix Common Printer Problems";
        video3._author = "IT Help Desk";
        video3._length = 730;

        video3._comments.Add(new Comment { _commenterName = "Robert", _text = "This fixed my printer queue issue." });
        video3._comments.Add(new Comment { _commenterName = "Ana", _text = "Very useful for work." });
        video3._comments.Add(new Comment { _commenterName = "Luis", _text = "Clear and easy steps." });

        videos.Add(video3);

        Video video4 = new Video();
        video4._title = "Beginner C# Classes Explained";
        video4._author = "Code Basics";
        video4._length = 910;

        video4._comments.Add(new Comment { _commenterName = "Ben", _text = "This helped me understand abstraction." });
        video4._comments.Add(new Comment { _commenterName = "Leah", _text = "The examples were very clear." });
        video4._comments.Add(new Comment { _commenterName = "Pablo", _text = "Great video for beginners." });

        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}