using CompilerCSharp.Source.Buffer;
using CompilerCSharp.Source.Tokens;

namespace CompilerCSharp.Source.Scanner
{
    public class TextScanner:Scanner
    {
        protected TextInBuffer buffer;
        public TextScanner(TextInBuffer buffer) : base()
        {
            this.buffer = buffer;
            InitializeCharacterCodeMap();
        }

        public override Token GetToken()
        {
            Token token;
            SkipWhiteSpace();

            switch (Common.Common.CharCodeMap[buffer.CurrentChar])
            {
                case Misc.Codes.CharCode.Letter:
                    token = wordToken;
                    break;
                case Misc.Codes.CharCode.Digit:
                    token = numberToken;
                    break;
                case Misc.Codes.CharCode.Quote:
                    token = stringToken;
                    break;
                case Misc.Codes.CharCode.Special:
                    token = specialToken;
                    break;
                case Misc.Codes.CharCode.EndOfFile:
                    token = eofToken;
                    break;
                default:
                    token = errorToken;
                    break;
            }

            token.GetToken(buffer);

            return token;
        }

        public void SkipWhiteSpace()
        {
            char character = buffer.CurrentChar;
            if (character == Common.Common.StartOfFile)
            {
                character = buffer.GetChar();
            }
            while(character==' ')
            {
                character = buffer.GetChar();
            }
        }

        private void InitializeCharacterCodeMap()
        {
            int i;
            for(i=0; i<127; ++i)
            {
                Common.Common.CharCodeMap[i] = Misc.Codes.CharCode.Error;
            }

            for(i='a'; i<='z'; ++i)
            {
                Common.Common.CharCodeMap[i] = Misc.Codes.CharCode.Letter;
            }

            for (i = 'A'; i <= 'Z'; ++i)
            {
                Common.Common.CharCodeMap[i] = Misc.Codes.CharCode.Letter;
            }

            for (i = '0'; i <= '9'; ++i)
            {
                Common.Common.CharCodeMap[i] = Misc.Codes.CharCode.Digit;
            }

            Common.Common.CharCodeMap['+'] = Common.Common.CharCodeMap['-'] = Misc.Codes.CharCode.Special;
            Common.Common.CharCodeMap['*'] = Common.Common.CharCodeMap['/'] = Misc.Codes.CharCode.Special;
            Common.Common.CharCodeMap['='] = Common.Common.CharCodeMap['^'] = Misc.Codes.CharCode.Special;
            Common.Common.CharCodeMap['.'] = Common.Common.CharCodeMap[','] = Misc.Codes.CharCode.Special;
            Common.Common.CharCodeMap['<'] = Common.Common.CharCodeMap['>'] = Misc.Codes.CharCode.Special;
            Common.Common.CharCodeMap['('] = Common.Common.CharCodeMap[')'] = Misc.Codes.CharCode.Special;
            Common.Common.CharCodeMap['['] = Common.Common.CharCodeMap[']'] = Misc.Codes.CharCode.Special;
            Common.Common.CharCodeMap['{'] = Common.Common.CharCodeMap['}'] = Misc.Codes.CharCode.Special;
            Common.Common.CharCodeMap[':'] = Common.Common.CharCodeMap[';'] = Misc.Codes.CharCode.Special;
            Common.Common.CharCodeMap[' '] = Common.Common.CharCodeMap['\t'] = Misc.Codes.CharCode.Special;
            Common.Common.CharCodeMap['\n'] = Common.Common.CharCodeMap['\0'] = Misc.Codes.CharCode.Special;
            Common.Common.CharCodeMap['\''] =  Misc.Codes.CharCode.Quote;
            Common.Common.CharCodeMap[Common.Common.EndOfFile] = Misc.Codes.CharCode.EndOfFile;
        }
    }
}
