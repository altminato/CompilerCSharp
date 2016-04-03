using CompilerCSharp.Source.Buffer;
using CompilerCSharp.Source.Common;
using CompilerCSharp.Source.Parsers;
using System;

namespace CompilerCSharp
{
    class Compiler
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Pascal Compiler");
            

            String filename = @"..\..\test.txt";
            /*TSourceBuffer buffer = new TSourceBuffer(filename);
            char line;
            while ((line=buffer.GetChar()) != Common.EndOfFile)
            {
                Console.WriteLine("*"+line+"*");
            }*/

            TSourceBuffer buffer = new TSourceBuffer(filename);
            SimpleParser parser = new SimpleParser(buffer);
            TListBuffer listBuffer = new TListBuffer(filename);
            Common.ListBuffer = listBuffer;

            parser.Parse();

            Console.Read();
        }
    }
}
