using System;

class Program
{
    static void Main(string[] args)
    {
        Video video = new Video("How to be the best person:", "Vinnicius Castro", 2, 10);
        Comment comment = new Comment("Zendaya", "SERVING SERVING SERVING, you are the best love ya");
        Comment comment1 = new Comment("Miley Cyrus", "I loved your video thank you for being so thoughtful");
        Comment comment2 = new Comment("Adele", "This video is so monumental!");
        Video video1 = new Video("Don't be a hater", "Vinni", 0,08);
        Comment comment3 = new Comment("Taylor Swift", "Haters are gonna hate");
        Comment comment4 = new Comment("Beyonce", "Respect that and bowl down");
        Comment comment5 = new Comment("Rihanna", "Like bra, bra, bra");
        Video video3 = new Video("How to be polite", "VC", 1, 42);
        Comment comment6 = new Comment("Selena Gomez", "I love you like a love song baby");
        Comment comment7 = new Comment("Drake", "It go, right foot up, left foot slide");
        Comment comment8 = new Comment("Pikachu", "Pika Pika chuuu");



        Console.WriteLine("Video 1 - information:");
        Console.WriteLine(video.Display());
        Console.WriteLine();
        Console.WriteLine("Comments:");
        Console.WriteLine(comment.Display());
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine(comment1.Display());
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine(comment2.Display());
        Console.WriteLine();
        Console.WriteLine("Video 2 - information:");
        Console.WriteLine(video1.Display());
        Console.WriteLine();
        Console.WriteLine("Comments:");
        Console.WriteLine(comment3.Display());
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine(comment4.Display());
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine(comment5.Display());
        Console.WriteLine();
        Console.WriteLine("Video 3 - information:");
        Console.WriteLine(video3.Display());
        Console.WriteLine();
        Console.WriteLine("Comments:");
        Console.WriteLine(comment6.Display());
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine(comment7.Display());
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine(comment8.Display());
        Console.WriteLine();
        
        
    }
}

class Video { 
    public string author; 
    public string title; 
    public int min;
    public int sec;

    public Video(string title1, string author1, int min1, int sec1) {
        min = min1;
        sec = sec1;
        author = author1;
        title = title1;

    }
    public string Display(){ 
        return $"Video Title: {title} Author: {author}\nThe total length of the video is: {min}:{sec}";
    }
}

class Comment {
    public string name;
    public string comment;

    public Comment(string name1, string comment2){
        name = name1;
        comment = comment2;
    }   
    public string Display() {
        return $"  Name: {name}\n  {comment}";
    }
}