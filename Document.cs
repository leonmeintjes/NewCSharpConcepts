using System;
using System.Dynamic;

namespace NewCSharpConcepts
{
    public class Document : IStorable, IRecording
    {
        public void Speak()
        {
            Console.WriteLine("Initialise recording (speak)...");
        }

        public void Read(string filename)
        {
            Console.WriteLine($"Reading document {filename}...");
        }

        public void Write(string filename)
        {
            Console.WriteLine($"Writing document {filename}...");
        }

        public void Reformat(string filename)
        {
            Console.WriteLine($"Reformatting document {filename}...");

        }

        public double DurationOfSpeech
        {
            get { return 42.00; }
        }



    }
}