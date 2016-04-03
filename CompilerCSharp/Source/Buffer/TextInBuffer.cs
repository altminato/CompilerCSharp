using CompilerCSharp.Source.Error;
using System;
using System.Linq;

namespace CompilerCSharp.Source.Buffer
{
    public abstract class TextInBuffer
    {

        #region Protected Fields
        private String filename;
        protected String[] lines;
        protected int linesPosition = 0;
        protected char currentChar=Common.Common.StartOfFile;
        protected String currentLine=null;
        protected int currentLinePosition;
        private bool pendingToPrint;
        private bool printNow;
        #endregion
        

        public TextInBuffer(String filename, AbortCodes.AbortCode abortCode)
        {
            this.filename = filename;
            try
            {
                lines = System.IO.File.ReadAllLines(filename);
            }
            catch(Exception)
            {
                AbortCodes.AbortTranslation(abortCode);
            }
        }

        public abstract String GetLine();

        public char CurrentChar
        {
            get { return currentChar; }
        }

        public char GetChar()
        {
            if (printNow == false)
                printNow = true;
            if ((currentLine == null) || (currentLinePosition >= currentLine.Length))
            {
                currentLine = GetLine();
                currentLinePosition = 0;
                pendingToPrint = true;
                printNow = false;
            }

            if (currentLine == null)
            {
                currentChar = Common.Common.EndOfFile;
                return Common.Common.EndOfFile;
            }

            if(pendingToPrint && printNow)
            {
                Common.Common.ListBuffer.PutLine(currentLine, Common.Common.CurrentLineNumber, Common.Common.CurrentNestingLevel);
                pendingToPrint = false;
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
