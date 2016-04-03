using CompilerCSharp.Source.Buffer;
using CompilerCSharp.Source.Scanner;
using CompilerCSharp.Source.Tokens;
using System;
using static CompilerCSharp.Source.Misc.Codes;

namespace CompilerCSharp.Source.Parsers
{
    public class SimpleParser
    {
        private TextScanner textScanner;
        private Token token;
        private TokenCode tokenCode;

        public SimpleParser(TextInBuffer buffer)
        {
            textScanner = new TextScanner(buffer);
        }

        private void GetToken()
        {
            token = textScanner.GetToken();
            tokenCode = token.Code;
        }

        public void Parse()
        {
            do
            {
                GetToken();
                if (tokenCode != TokenCode.Error)
                {
                    token.Print();
                }
                else
                {
                    Console.WriteLine("\t>> *** ERROR ***\t" + token.String);
                    Common.Common.CurrentErrorCount += 1;
                }

            } while (tokenCode != TokenCode.EndOfFile);

            Console.WriteLine(Common.Common.CurrentLineNumber + " source lines.");
            Console.WriteLine(Common.Common.CurrentErrorCount + " syntax errors.");
        }
    }
}
