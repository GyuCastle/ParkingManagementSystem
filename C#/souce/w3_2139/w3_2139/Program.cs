using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3_2139
{
    using System;
    class Fraction
    {
        private int numerator;
        private int denominator;
        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public int Denominator
        {
            get { return denominator; }
            set { denominator = value; }
        }
        override public string ToString()
        {
            return (numerator + "/" + denominator);
        }
    }
    class PropertyApp
    {
        public static void Main()
        {
            Fraction f = new Fraction(); int i;
            f.Numerator = 1; // Numerator이 왼쪽에 있으면 set
            i = f.Numerator + 1; // Numerator이 오른쪽에 있으면 get
            f.Denominator = i; // i 값으로 set
            Console.WriteLine(f.ToString());
        }
    }
}
