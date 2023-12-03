using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.PR3
{
    public class Calculation_abc
    {
        public Calculation_abc(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        int a, b, c;

        public int A { get; set; }

        public int B { get; set; }

        public int C { get; set; }

        public double D()
        {
            if (a > 0 || b > 0 || c > 0)
            {
                return Math.Pow(a + b + c, 2);
            }
            else
            {
                return Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2);
            }
        }
    }
}
