using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExample
{
    public class Calculator
    {
        public static double Calculate(int a, int b, String n)
        {
            if (a > 1000 || a < -1000 || b > 1000 || b < -1000)
            {
                throw new IndexOutOfRangeException("Input phai nam trong khoang [-1000,1000]");
            }

            String[] validMethods = { "+", "-", "*", "/" };
            if (Array.IndexOf(validMethods, n) == -1)
            {
                throw new ArgumentException("Phep tinh phai la +, -, *, /");
            }

            switch (n)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    if (b == 0)
                    {
                        throw new ArgumentException("Khong the chia cho 0");
                    }
                    else
                    {
                        return (double)a / b;
                    }
                default:
                    return 0;
            }
        }
    }
}
