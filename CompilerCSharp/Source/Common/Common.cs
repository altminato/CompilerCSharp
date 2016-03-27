using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompilerCSharp.Source.Common
{
    public static class Common
    {
        static int currentLineNumber;
        static int currentNestingLevel;

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
    }
}
