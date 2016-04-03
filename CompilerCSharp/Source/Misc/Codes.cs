
namespace CompilerCSharp.Source.Misc
{
    public static class Codes
    {
        public enum CharCode
        {
            Letter,
            Digit,
            Special,
            Quote,
            Whitespace,
            EndOfFile,
            Error
        };

        public enum TokenCode
        {
            Dummy,
            Word,
            Number,
            Period,
            EndOfFile,
            Error
        };

        public enum DataType
        {
            Dummy,
            Integer,
            Real,
            Character,
            String
        };
    }
}
