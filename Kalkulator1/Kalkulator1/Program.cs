using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solver;

namespace Kalkulator1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var a = double.Parse(Console.ReadLine());
            //var b = double.Parse(Console.ReadLine());
            //var c = double.Parse(Console.ReadLine());

            //var result = QuadraticEquationsSolver.Solve(a, b, c);

            //Console.WriteLine(result[0]);
            //Console.WriteLine(result[1]);
            //Console.ReadKey();

            Console.WriteLine("������� ������ �����: ");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("������� ��������: ");
            var c = char.Parse(Console.ReadLine());
            Console.WriteLine("������� ������ �����: ");
            var b = double.Parse(Console.ReadLine());
            double result = 0;
            if (c=='+')
            {
                result = a + b;
            }
            else if (c == '-')
            {
                result = a - b;
            }
            else if (c == '*')
            {
                result = a * b;
            }
            else if (c == '/')
            {
                result = a / b;
            }
            else
                Console.WriteLine("�� ����� �������� ��������: ");

            Console.WriteLine("��� �����: ");
            Console.WriteLine(result);


        }
    }
}
