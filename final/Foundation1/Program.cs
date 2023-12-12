using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new();
        Video video1 = new();
        video1._title = "Title 1";
        video1._author = "Author 1";
        video1._length = 312f;
        video1.AddComment(new Comment("Commentor 1", "Comment 1"));
        video1.AddComment(new Comment("Commentor 2", "Comment 2"));
        video1.AddComment(new Comment("Commentor 3", "Comment 3"));
        videos.Add(video1);
        
        Video video2 = new();
        video2._title = "Title 2";
        video2._author = "Author 2";
        video2._length = 452f;
        video2.AddComment(new Comment("Commentor 4", "Comment 4"));
        video2.AddComment(new Comment("Commentor 5", "Comment 5"));
        video2.AddComment(new Comment("Commentor 6", "Comment 6"));
        videos.Add(video2);
        
        Video video3 = new();
        video3._title = "Title 3";
        video3._author = "Author 3";
        video3._length = 784f;
        video3.AddComment(new Comment("Commentor 7", "Comment 7"));
        video3.AddComment(new Comment("Commentor 8", "Comment 8"));
        video3.AddComment(new Comment("Commentor 9", "Comment 9"));
        videos.Add(video3);
        
        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }
    }
}