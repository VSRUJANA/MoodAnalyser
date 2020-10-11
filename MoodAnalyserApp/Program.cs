using System;

namespace MoodAnalyserApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser App!");
            Console.WriteLine("Enter message");
            MoodAnalyser m = new MoodAnalyser();
            m.message = Console.ReadLine();
            Console.WriteLine("Mood : " + m.AnalyseMood());
        }
    }
}
