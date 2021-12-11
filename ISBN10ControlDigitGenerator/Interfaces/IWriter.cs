namespace ISBN10ControlDigitGenerator.Interfaces
{
    public interface IWriter
    {
        void Clear();
        void WriteLine(string input);
        void Write(string input);
    }
}