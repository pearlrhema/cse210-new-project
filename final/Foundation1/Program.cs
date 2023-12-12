using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new();
        Video video1 = new();
        video1._title = "The Oval";
        video1._author = "Tyler Perrys";
        video1._length = 312f;
        video1.AddComment(new Comment("Godwin Essien", "I have never watch this movie befor"));
        video1.AddComment(new Comment("Blessing Essien", "I hope it will be a nice video"));
        video1.AddComment(new Comment("Dara Godwin", "I dont have internet connection to watch the movie thanks"));
        videos.Add(video1);
        
        Video video2 = new();
        video2._title = "Prison Break";
        video2._author = "Trailer";
        video2._length = 452f;
        video2.AddComment(new Comment("Aboki", "Nothing really captured my heart about the movie"));
        video2.AddComment(new Comment("Jarelle Nolwene", "after seeing the commercial it did not strike me as something that i wanted to see "));
        video2.AddComment(new Comment("Moon#", "I really enjoyed the movie though"));
        videos.Add(video2);
        
        Video video3 = new();
        video3._title = "Swallow";
        video3._author = "Nollywood";
        video3._length = 784f;
        video3.AddComment(new Comment("Fat Makeup", "I am very impressed by the movie"));
        video3.AddComment(new Comment("Scuderia", "compelling story"));
        video3.AddComment(new Comment("SKY M KAKASHI", "swallow addresses deep societal issues on a surface level"));
        videos.Add(video3);
        
        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }
    }
}
//the foundation 1 and 2 are working well though i am yet to complete the foundation 3 and 4