using ObserverPattern.Notifiers;
using System;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var videoData = new VideoData();
            _ = new EmailNotifier(videoData);
            _ = new PhoneNotifier(videoData);
            var youtubeNotifier = new YoutubeNotifier(videoData);

            videoData.SetTitle("Observer Design Pattern");

            // can change Observer in run time
            // save time and resources
            videoData.DetechObserver(youtubeNotifier);
            Console.WriteLine("-----------------------------");
            videoData.SetDescription("Tai dep trai");

            _ = new FacebookNotifier(videoData);
            Console.WriteLine("-----------------------------");
            videoData.SetFileName("Very good");
        }
    }
}
