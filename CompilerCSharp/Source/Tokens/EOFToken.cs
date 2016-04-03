using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompilerCSharp.Source.Buffer;

namespace CompilerCSharp.Source.Tokens
{
    public class EOFToken:Token
    {
        public EOFToken() : base() { }

        public override void GetToken(TextInBuffer buffer)
        {
            code = Misc.Codes.TokenCode.EndOfFile;
        }

        public override void Print()
        {
            
        }
    }
}
