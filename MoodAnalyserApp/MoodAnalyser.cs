using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserApp
{
    public class MoodAnalyser
    {
        public string message;
        //Default constructor
        public MoodAnalyser() { }
        //Parameterised Constructor
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            if (message.ToUpper().Contains("SAD"))
            {
                return "SAD";
            }
            else if (message.ToUpper().Contains("HAPPY"))
            {
                return "HAPPY";
            }
            return null;
        }
    }
}
