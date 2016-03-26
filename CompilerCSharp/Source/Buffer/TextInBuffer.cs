using System;
using System.Linq;

namespace CompilerCSharp.Source.Buffer
{
    public abstract class TextInBuffer
    {

        #region Constants
        public const char EndOfFile = '\0';
        #endregion

        #region Protected Fields
        private String filename;
        protected String[] lines;
        protected int linesPosition = 0;
        protected char currentChar;
        protected String currentLine;
        protected int currentLinePosition;
        #endregion


        public char CurrentChar
        {
            get { return currentChar; }
        }

        public TextInBuffer(String filename)
        {
            this.filename = filename;
            try
            {
                lines = System.IO.File.ReadAllLines(filename);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public abstract String GetLine();

        public char GetChar()
        {
            if ((currentLine == null) || (currentLinePosition >= currentLine.Length))
            {
                currentLine = GetLine();
                currentLinePosition = 0;
            }

            if (currentLine == null)
            {
                return EndOfFile;
            }

            currentChar = currentLine.ElementAt(currentLinePosition);
            currentLinePosition++;

            return currentChar;
        }

        public char PutBackChar()
        {
            currentLinePosition--;
            currentChar = currentLine.ElementAt(currentLinePosition);
            return currentChar;
        }
    }
}
