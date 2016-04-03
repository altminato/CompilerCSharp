using System;
using CompilerCSharp.Source.Buffer;
using CompilerCSharp.Source.Common;
using static CompilerCSharp.Source.Misc.Codes;

namespace CompilerCSharp.Source.Tokens
{
    public class WordToken:Token
    {
        public WordToken():base() { }

        public override void GetToken(TextInBuffer buffer)
        {
            char character = buffer.CurrentChar;
            String temporalWord = "";

            do
            {
                temporalWord += character;
                character = buffer.GetChar();

            } while ( (Common.Common.CharCodeMap[character])== Misc.Codes.CharCode.Letter ||
            (Common.Common.CharCodeMap[character]) == Misc.Codes.CharCode.Digit);
            stringElement = temporalWord;
            code = TokenCode.Word;
        }

        public override void Print()
        {
            Console.WriteLine("\t>> word:\t\t" + stringElement);
            Common.Common.ListBuffer.PutLine();
        }
    }
}
