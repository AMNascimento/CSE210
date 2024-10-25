using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Party", "Joe Cool", 50);
        Video v2 = new Video("Yoga Class", "Jane Smith", 168);
        Video v3 = new Video("Wether Forcast", "Bob Storm", 487);

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        Comment c1 = new Comment("Jay", "Nice video!");
        Comment c2 = new Comment("Mary", "I loved your video!");
        Comment c3 = new Comment("Paul", "I want more videos!");
        Comment c4 = new Comment("Mike", "You are funny.");
        Comment c5 = new Comment("Anna", "First comment");
        Comment c6 = new Comment("Bill", "Great job!");
        Comment c7 = new Comment("Joseph", "More videos lile this.");
        Comment c8 = new Comment("Carl", "LOL!");
        Comment c9 = new Comment("Rose", "Good job!");

        v1.AddComment(c1);
        v1.AddComment(c2);
        v1.AddComment(c3);
        v2.AddComment(c4);
        v2.AddComment(c5);
        v2.AddComment(c6);
        v3.AddComment(c7);
        v3.AddComment(c8);
        v3.AddComment(c9);

        foreach (Video video in videos)
        {
            Console.WriteLine($"\n{video.DisplayVideo()}");
            Console.WriteLine($"Number of comments: {video.GetCommentsQty()}");
            video.DisplayComments();
        }
    }
}