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
            z = x * y;
            return z;
        }

        // 引き算
        public int Sub(int x, int y)
        {
            int z;
            z = x - y;
            return z;
        }

    }
}
