using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserApp
{
    public class MoodAnalyser
    {
        public string AnalyseMood(string msg)
        {
            if (msg.ToUpper().Contains("SAD"))
            {
                return "SAD";
            }
            return "HAPPY";
        }
    }
}
