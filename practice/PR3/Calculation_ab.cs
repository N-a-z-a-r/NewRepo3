using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.PR3
{
    public class Calculation_ab
    {
        int a, b;
        public Calculation_ab(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int A { get { return a; } }
        public int B { get { return b; } }

        public int Sun()
        {
            var count = 0;

            if (a > b)
                // генеруємо помилку
                throw new ArgumentOutOfRangeException("A should be less than B!");

            if (a == b)
                return 0;

            for (int i = a; i <= b; i++)
            {
                if (i % 29 == 0 && i % 2 == 0 && i % 5 == 2)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
