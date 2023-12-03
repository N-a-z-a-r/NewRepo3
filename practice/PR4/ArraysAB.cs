using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.PR4
{
    internal class ArraysAB
    {
        public int[] a;
        public int[] b;
        int length = 0;
        public int Length { get { return length; } set { length = value; } }
        public ArraysAB(int n) { a = new int[n]; }
        public void calculate()
        {
            // змінюємо розмірність масивів відповідно до фактичних значень 
            Array.Resize(ref a, length);

            int j = 0, jj = 0;
            int[] b1 = new int[length];
            int[] b2 = new int[length];

            for (int i = 0; i < length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    b1[j] = a[i];
                    j++;
                }
                else
                {
                    b2[jj] = a[i];
                    jj++;
                }
            }

            // змінюємо розмірність масивів відповідно до фактичних значень
            Array.Resize(ref b1, j);
            Array.Resize(ref b2, jj);

            b = new int[length];

            // об'єднуємо масив 
            b = b1.Concat(b2).ToArray();
        }
    }
}
