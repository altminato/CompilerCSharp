using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompilerCSharp.Source.Buffer
{
    public class TListBuffer:TextOutBuffer
    {
        #region Constants
        public const int MaximumLinesPerPage = 50;
        #endregion

        #region Fields
        private String date;
        private int pageNumber;
        private bool listFlag;
        private int lineCount;
        public bool ListFlag
        {
            set
            {
                listFlag = value;
            }
            get { return listFlag; }
        }

        public int LineCount
        {
            set
            {
                lineCount = value;
            }
            get { return lineCount; }
        }

        #endregion

        public TListBuffer(String filename) : base(filename)
        {
            
        }

        public void PrintPageHeader()
        {

        }

        public override void PutLine()
        {
            if (ListFlag && (LineCount == MaximumLinesPerPage))
            {
                PrintPageHeader();
            }

            Console.WriteLine(currentText);

            currentText = "";
            LineCount++;
        }

        private void Initialize(String filename)
        {
            pageNumber = 0;
            this.filename = filename;
            date = DateTime.Now.ToString();
            PrintPageHeader();
        }
    }
}
