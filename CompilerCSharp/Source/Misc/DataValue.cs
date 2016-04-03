
namespace CompilerCSharp.Source.Misc
{
    public class DataValue
    {
        private int integer;
        private float real;
        private char character;
        private string stringElement;

        public int Integer
        {
            set { integer = value; }
            get { return integer; }
        }

        public float Real
        {
            set { real = value; }
            get { return real; }
        }
        
        public char Character
        {
            set { character = value; }
            get { return character; }
        }

        public string StringElement
        {
            set { stringElement = value; }
            get { return stringElement; }
        }
        public DataValue() { }

    }
}
