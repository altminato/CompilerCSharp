using CompilerCSharp.Source.Tokens;

namespace CompilerCSharp.Source.Scanner
{
    public abstract class Scanner
    {
        protected WordToken wordToken;
        protected NumberToken numberToken;
        protected StringToken stringToken;
        protected SpecialToken specialToken;
        protected EOFToken eofToken;
        protected ErrorToken errorToken;

        public Scanner()
        {
            wordToken = new WordToken();
            numberToken = new NumberToken();
            stringToken = new StringToken();
            specialToken = new SpecialToken();
            eofToken = new EOFToken();
            errorToken = new ErrorToken();
        }

        public abstract Token GetToken();
    }
}
