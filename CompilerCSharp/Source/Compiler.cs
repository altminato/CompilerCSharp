using CompilerCSharp.Source.Buffer;
using System;

namespace CompilerCSharp
{
    class Compiler
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Pascal Compiler");
            

            String filename = @"..\..\test.txt";
            TSourceBuffer buffer = new TSourceBuffer(filename);
            char line;
            while ((line=buffer.GetChar()) != TextInBuffer.EndOfFile)
            {
                Console.WriteLine("*"+line+"*");
            }

            Console.Read();
        }
    }
}
