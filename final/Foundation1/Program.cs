using System;

class Program
{
    static void Main(string[] args)
    {
        Video video = new Video();
        Comment comment = new Comment();

        Console.WriteLine("Video information:");
        Console.WriteLine(video.Display("How to be the best person:", "Vinnicius Castro", 2, 10));
        Console.WriteLine();
        Console.WriteLine("Comments:");
        Console.WriteLine(comment.Display("Zendaya", "SERVING SERVING SERVING, you are the best love ya"));
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine(comment.Display("Miley Cyrus", "I loved your video thank you for being so thoughtful"));
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine(comment.Display("Adele", "This video is so monumental!"));
        
    }
}

class Video { 
    public string author; 
    public string title; 
    public int min;
    public int sec;

    public string Display(string title, string author, int min, int sec){ 
        return $"Video Title: {title} Author: {author}\nThe total length of the video is: {min}:{sec}";
    }
}

class Comment {
    public string name;
    public string comment;

    public string Display(string name, string comment) {
        return $"  Name: {name}\n  {comment}";
    }
}