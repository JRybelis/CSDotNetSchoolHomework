namespace ISBN10ControlDigitGenerator.Interfaces
{
    public interface IWriter
    {
        void Clear();
        void Write(string input);
    }
}