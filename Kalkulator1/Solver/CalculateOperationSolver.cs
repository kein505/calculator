using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solver
{
    public class CalculateOperationSolver
    {
        public static double Solve(double a, string c, double b)
        {
            try
            {
                if (c == "+")
                {
                    return (a + b);
                }
                else if (c == "-")
                {
                    return (a - b);
                }
                else if (c == "*")
                {
                    return (a * b);
                }
                else if (c == "/")
                {
                    return (a / b);
                }
                else if (c == "sqrt")
                {
                    return Math.Sqrt(a);
                }
                else if (c == "1/x")
                {
                    return (1/a);
                }
                else
                {
                    Console.WriteLine("Вы ввели неверный оператор: ");
                    return 0;
                }
            }
            catch (System.FormatException)
            {
                // тут вывести в консоль ошибку.
                Console.WriteLine("Ошибка ввода! ");
                return 0;
            }


            // 7) Операция 
            // 8) Операция 
        }
    }
}
