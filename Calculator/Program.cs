using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            // 数字の入力
            Console.Write("x >");
            x = int.Parse(Console.ReadLine());
            Console.Write("y >");
            y = int.Parse(Console.ReadLine());

            // 計算するよ
            Console.Write("+/-/*// >");
            var input = Console.ReadLine();
            var op = input[0];

            var calc = new Calc();
            int z;
            switch(op)
            {
                case '+':
                    z = calc.Sum(x, y);
                    Console.WriteLine("Ans : " + z);
                    break;

                case '-':
                    z = calc.Sub(x, y);
                    Console.WriteLine("Ans : " + z);
                    break;

                case '*':
                    z = calc.Mul(x, y);
                    Console.WriteLine("Ans : " + z);
                    break;

                case '/':
                    double ans = calc.Div(x, y);
                    Console.WriteLine("Ans : " + ans);
                    break;

                default:
                    Console.WriteLine("しらん : " + op);
                    break;
            }

        }
    }
}
