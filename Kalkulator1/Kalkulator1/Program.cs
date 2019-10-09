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
            char again = 'y';
            while (again == 'y')
            {
                try
                { 
                    Console.WriteLine("Введите первое число: ");
                    //double a = Vvod();
                    double a = ReadDouble(IsNumber);
                    //var a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите операцию: ");
                    var c = Console.ReadLine();
                    Console.WriteLine("Введите второе число: ");
                    //var b = double.Parse(Console.ReadLine());
                    //double b = Vvod();
                    double b = ReadDouble(IsNumber);

                    var result = CalculateOperationSolver.Solve(a, c, b);

                    Console.WriteLine("Ваш ответ: ");
                    Console.WriteLine(result);

                    Console.WriteLine("Вы хотите продолжить работу с калькулятором? (y/n)");
                    again = Convert.ToChar(Console.ReadLine());
                }
            catch (System.FormatException)
                {
                    // тут вывести в консоль ошибку.
                    Console.WriteLine("Ошибка ввода! ");
                }
            }
        }

        //static double Vvod()
        //{
        //    while (true)
        //    {
        //        double i;
        //        if (double.TryParse(Console.ReadLine(), out i))
        //            return i;
        //        else
        //            Console.Write("Ошибка ввода! Введите еще раз: ");
        //    }
        //}

        static double ReadDouble(Predicate<double> validate = null)
        {
            double result;
            while (!double.TryParse(Console.ReadLine(), out result) || (validate != null && !validate(result)))
                Console.Write("Invalid number, try again: ");
            return result;
        }
        static bool IsNumber(double value)
        {
            return !double.IsNaN(value);
        }
    }
}
