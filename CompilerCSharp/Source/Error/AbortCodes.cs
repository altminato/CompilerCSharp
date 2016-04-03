using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompilerCSharp.Source.Error
{
    public static class AbortCodes
    {

        public enum AbortCode
        {
            AbortInvalidCommandLineArgs = 1,
            AbortSourceFileOpenFailed,
            AbortFormFileOpenFailed,
            AbortAssemblyFileOpenFailed,
            AbortTooManuSintaxErros,
            AbortStackOverflow,
            AbortCodeSegmentOverflow,
            AbortNestingTooDeep,
            AbortRuntimeError,
            AbortUnimplementedFeature
        };

        public static String[] AbortMessage =
        {
            "",
            "Invalid command line arguments",
            "Failed to open source file",
            "Failed to open intermediate from file",
            "Failed to open assembly file",
            "Too many syntax errors",
            "Stack overflow",
            "Code segment overflow",
            "Nesting too deep",
            "Runtime error",
            "Unimplemented feature"
        };

        public static void AbortTranslation(AbortCode abortCode)
        {
            int index = (int)abortCode;
            Console.WriteLine("Fatal translator error: "+AbortMessage[index]);
            Environment.Exit(index);
        }
    }
}
