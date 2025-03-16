class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Basics", "John Doe", 600);
        video1.AddComment("Alice", "Great explanation!");
        video1.AddComment("Bob", "Very helpful, thanks!");
        video1.AddComment("Charlie", "Could you cover interfaces next?");
        videos.Add(video1);

        Video video2 = new Video("Advanced C# Techniques", "Jane Smith", 900);
        video2.AddComment("Dave", "Mind-blowing concepts!");
        video2.AddComment("Eve", "I love the examples used.");
        video2.AddComment("Frank", "Very well structured video.");
        videos.Add(video2);

        Video video3 = new Video("LINQ in C#", "Mark Johnson", 750);
        video3.AddComment("Grace", "I finally understand LINQ!");
        video3.AddComment("Hank", "Clear and concise, thank you!");
        video3.AddComment("Ivy", "Would love a part 2 on this topic.");
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}