﻿
using System;

namespace CompilerCSharp.Source.Buffer
{
    public abstract class TextOutBuffer
    {
        protected String filename;
        protected String currentText;

        public String CurrentText
        {
            set { currentText = value; }
            get { return currentText; }
        }

        public TextOutBuffer(String filename)
        {
            this.filename = filename;
        }

        public abstract void PutLine();

        protected void PutLine(String line)
        {
            currentText = line;
            PutLine();
        }
    }
}
