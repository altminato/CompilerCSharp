﻿using CompilerCSharp.Source.Error;
using System;

namespace CompilerCSharp.Source.Buffer
{
    public class TSourceBuffer:TextInBuffer
    {
        public TSourceBuffer(String filename):base(filename, AbortCodes.AbortCode.AbortFormFileOpenFailed) {}

        public override String GetLine()
        {
            if(linesPosition >= lines.Length)
            {
                return null;
            }
            String line = lines[linesPosition];
            linesPosition++;
            Common.Common.CurrentLineNumber += 1;
            return line;
        }
    }
}
