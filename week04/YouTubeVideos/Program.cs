using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video game = new Video("Sony","Play Station 3 setup", 234);
        game.AddComment("Donald Duke", "This video made it easy to setup my play station console.");
        game.AddComment("John Don", "I'm still not able to find my way around.");
        game.AddComment("Rust", $"Thank you @{game._author}.");
        videos.Add(game);

        Video game1 = new Video("Blake","GTA-5", 345);
        game1.AddComment("lecrae", "Great game.");
        game1.AddComment("Moore", "Supeb graphics.");
        game1.AddComment("Tedashi","Great features.");
        videos.Add(game1);

        Video gameConsole = new Video("Microsoft","X-Box 1", 232);
        gameConsole.AddComment("Tracey","Great console to have.");
        gameConsole.AddComment("David Stone","I don't like this version of Console.");
        gameConsole.AddComment("Jordan harrison","One of the best Game Console.");
        videos.Add(gameConsole);

        Console.Clear();
        foreach (Video video in videos)
        {
            Console.WriteLine("=======================");
            video.DisplayVideoDetails();
            Console.WriteLine("=======================");
        }
        //Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
    }
}