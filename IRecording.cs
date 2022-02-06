namespace NewCSharpConcepts
{
    public interface IRecording
    {
        double DurationOfSpeech { get; }
        void Speak();
    }
}