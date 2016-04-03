using CompilerCSharp.Source.Buffer;

namespace CompilerCSharp.Source.Tokens
{
    public class ErrorToken:Token
    {
        public ErrorToken() : base() { }

        public override void GetToken(TextInBuffer buffer)
        {
            stringElement = "";
            stringElement += buffer.CurrentChar;

        }

        public override void Print()
        {
            
        }
    }
}
