using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calc
    {
        // 足し算
        public int Sum(int x, int y)
        {
            int z;
            z = x + y;
            return z;
        }

        // 引き算
        public int Sub(int x, int y)
        {
            int z;
            z = x - y;
            return z;
        }

        // 掛け算
        public int Mul(int x, int y)
        {
            int z;
            z = x * y;
            return z;
        }

        // 割り算
        public double Div(int x, int y)
        {
            if (y == 0)
            {
                return 0;
            }

            double z;
            z = (double)x / y;
            return z;
        }

    }
}
