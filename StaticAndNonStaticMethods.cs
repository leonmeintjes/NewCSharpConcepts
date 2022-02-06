using System;

namespace NewCSharpConcepts
{
    public class StaticAndNonStaticMethods
    {
        public double NonStaticMethod(string someText)
        {
            double theAnswer = Double.Parse(someText);
            return theAnswer;
        }

        public static double StaticMethod(string someText)
        {
            double theAnswer = Double.Parse(someText);
            return theAnswer;
        }
    }

    
}