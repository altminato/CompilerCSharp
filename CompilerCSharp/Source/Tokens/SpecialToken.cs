using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompilerCSharp.Source.Buffer;

namespace CompilerCSharp.Source.Tokens
{
    public class SpecialToken:Token
    {
        public SpecialToken() : base() { }

        public override void GetToken(TextInBuffer buffer)
        {
            char character = buffer.CurrentChar;
            stringElement = character + "";
            code = (character == '.') ? Misc.Codes.TokenCode.Period : Misc.Codes.TokenCode.Error;
            buffer.GetChar();
        }

        public override void Print()
        {
            Console.WriteLine("\t>> special:\t\t" + stringElement);
            Common.Common.ListBuffer.PutLine();
        }
    }
}
