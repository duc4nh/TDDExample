using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExample
{
    public class Calculator
    {
        public static int Calculate(int a, int b, String n)
        {
            if (a > 1000 || a < -1000 || b > 1000 || b < -1000)
            {
                throw new IndexOutOfRangeException("Input phai nam trong khoang [-1000,1000]");
            }
            
            return 0;
        }
    }
}
