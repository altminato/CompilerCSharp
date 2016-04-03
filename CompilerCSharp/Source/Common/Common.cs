using CompilerCSharp.Source.Buffer;
using static CompilerCSharp.Source.Misc.Codes;

namespace CompilerCSharp.Source.Common
{
    public static class Common
    {
        public const char EndOfFile = '\b';
        public const char StartOfFile = '\f';


        static int currentLineNumber;
        static int currentNestingLevel;
        static int errorCount;
        static TListBuffer list = null;

        public static int CurrentLineNumber
        {
            set
            {
                currentLineNumber = value;
            }
            get { return currentLineNumber; }
        }

        public static int CurrentNestingLevel
        {
            set
            {
                currentNestingLevel = value; 
            }
            get { return currentNestingLevel; }
        }

        public static int CurrentErrorCount
        {
            set
            {
                errorCount = value;
            }
            get { return errorCount; }
        }

        public static TListBuffer ListBuffer
        {
            set { list = value; }
            get { return list; }
        }

        public static CharCode[] CharCodeMap = new CharCode[128];
    }
}
