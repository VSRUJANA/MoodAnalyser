using System;

namespace MoodAnalyserApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser App!");
            Console.WriteLine("Enter message");
            string message = Console.ReadLine();
            MoodAnalyser m = new MoodAnalyser();
            Console.WriteLine("Mood : " + m.AnalyseMood(message));
        }
    }
}
