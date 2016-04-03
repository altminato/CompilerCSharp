using CompilerCSharp.Source.Buffer;
using CompilerCSharp.Source.Misc;
using static CompilerCSharp.Source.Misc.Codes;

namespace CompilerCSharp.Source.Tokens
{
    public abstract class Token
    {
        protected TokenCode code;
        protected DataType type;
        protected DataValue value;
        protected string stringElement;

        public TokenCode Code
        {
            get { return code; }
        }

        public DataType Type
        {
            get { return type; }
        }

        public DataValue Value
        {
            get { return value; }
        }

        public string String
        {
            get { return stringElement; }
        }

        public Token()
        {
            code = TokenCode.Dummy;
            type = DataType.Dummy;
            value = new DataValue();
            stringElement = "";
        }

        public abstract void GetToken(TextInBuffer buffer);

        public abstract void Print();
    }
}
