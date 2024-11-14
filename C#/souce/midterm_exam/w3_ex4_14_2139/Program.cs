using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3_ex4_14_2139
{
    internal class Program
    {
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
        static void Main(string[] args)
        {
            Fraction f = new Fraction(); int i;
            f.Numerator = 1; // invoke set-accessor in Numerator
            i = f.Numerator + 1; // invoke get-accessor in Numerator
            f.Denominator = i; // invoke set-accessor in Denominator
            Console.WriteLine(f.ToString()); // 1/2 출력
        }
    }
}
