using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompilerCSharp.Source.Buffer;

namespace CompilerCSharp.Source.Tokens
{
    public class NumberToken:Token
    {
        public NumberToken() : base(){ }

        public override void GetToken(TextInBuffer buffer)
        {
            int maxDigitCount = 4;
            char character = buffer.CurrentChar;
            int digitCount = 0;
            String temporalNumner = "";
            bool countErrorFlag = false;
            value.Integer = 0;

            do
            {
                temporalNumner += character;
                if(++digitCount> maxDigitCount)
                {
                    countErrorFlag = true;
                }
                character = buffer.GetChar();
            } while ((Common.Common.CharCodeMap[character]) == Misc.Codes.CharCode.Digit);

            if (!countErrorFlag)
            {
                try
                {
                    value.Integer = Convert.ToInt32(temporalNumner);
                }
                catch (Exception)
                {
                    countErrorFlag = true;
                }
            }
            stringElement = temporalNumner;
            code = (countErrorFlag) ? Misc.Codes.TokenCode.Error : Misc.Codes.TokenCode.Number;

        }

        public override void Print()
        {
            Console.WriteLine("\t>> number:\t\t" + value.Integer);
            Common.Common.ListBuffer.PutLine();
        }
    }
}
