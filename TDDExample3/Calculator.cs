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
            if (a > 1000)
            {
                throw new IndexOutOfRangeException("Input khong duoc vuot qua 1000");
            }
            if (b > 1000)
            {
                throw new IndexOutOfRangeException("Input khong duoc vuot qua 1000");
            }
            if (a < -1000)
            {
                throw new IndexOutOfRangeException("Input khong duoc nho hon -1000");
            }
            if (b < -1000)
            {
                throw new IndexOutOfRangeException("Input khong duoc nho hon -1000");
            }
            return 0;
        }
    }
}
