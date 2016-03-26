using System;

namespace CompilerCSharp.Source.Buffer
{
    public class TSourceBuffer:TextInBuffer
    {
        public TSourceBuffer(String filename):base(filename) {}

        public override String GetLine()
        {
            if(linesPosition >= lines.Length)
            {
                return null;
            }
            String line = lines[linesPosition];
            linesPosition++;
            return line;
        }
    }
}
