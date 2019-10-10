using System;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using Solver;

namespace NUnit_Kalkulator1.Tests
{
    [TestFixture] // <= это называется атрибут.
    // Таким атрибутом нужно пометить класс, чтобы система тестирования начала искать в нем тесты.
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test] // <= так нужно пометить метод, чтобы система тестирования поняла, что это тест.
        public void SingleTest()
        {
            var result = QuadraticEquationsSolver.Solve(1, -3, 2);
            Assert.AreEqual(2, result.Length);
        }

        [TestCase(1, -3, 2, 2, 1)] // не нужно помечать атрибутом [Test]
        [TestCase(1, 1, 1)] // каждый такой атрибут станет отдельным тестом
        [TestCase(2, 4, 2, -1)]
        public void TestCases(double a, double b, double c, params double[] expectedResult)
        {
            var result = QuadraticEquationsSolver.Solve(a, b, c);

            Assert.AreEqual(expectedResult.Length, result.Length);

            for (int i = 0; i < result.Length; i++)
                Assert.AreEqual(expectedResult[i], result[i]);
        }
    }

    public class CalculateTests
    {
            //[SetUp]
            //public void Setup()
            //{
            //}

        [Test] // <= так нужно пометить метод, чтобы система тестирования поняла, что это тест.
        public void Negative_Test()
        {
            var result = CalculateOperationSolver.Solve(1, "g", 2);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Negative_DelenieNaNull_Test()
        {
            var result = CalculateOperationSolver.Solve(1, "/", 0);
           // string expectedResult = "бесконечность";
            Assert.AreEqual(0, result);
        }
        [Test]
        public void Negative_DelenieNullNaNull_Test()
        {
            var result = CalculateOperationSolver.Solve(0, "/", 0);
            // string expectedResult = "бесконечность";
            Assert.AreEqual(0, result);
        }

        [TestCase(-10, "+", -10, -20)]
        [TestCase(3, "-", 2, 1)]
        [TestCase(1, "*", 2, 2)]
        [TestCase(1, "/", 2, 0.5)]
        [TestCase(16, "sqrt", 0, 4)]
        [TestCase(16, "square", 0, 256)]
        [TestCase(2, "1/x", 0, 0.5)]
        [TestCase(1.564, "*", 0, 0)]
        [TestCase(5.3, "*", 2.8, 14.84)]
        [TestCase(-3, "-", 2, -5)]
        [TestCase(-3, "*", 2, -6)]

        public void Pasitive_TestCases(double a, string b, double c, double expectedResult)
        {
                var result = CalculateOperationSolver.Solve(a, b, c);

                Assert.AreEqual(expectedResult, result, 1e-10);

                //for (int i = 0; i < result.Length; i++)
                //    Assert.AreEqual(expectedResult[i], result[i]);
        }

       // [TestCase("g", "/", 2, 0)]
       //// [TestCase(16, "/", 0, "бесконечность")]
       // public void Vvod_ne_chisla_Negative_TestCases(double a, string b, double c, double expectedResult)
       // {
       //     var result = CalculateOperationSolver.Solve(a, b, c);

       //     Assert.AreEqual(expectedResult, result);
       // }

        [Test]
        public void FunctionTest()
        {
            for (int i = 0; i < 100; i++)
            {
                string[] operation = {"+", "-", "*", "/", "sqrt", "square", "1/x" }; //, "sqrt"
                var rnd = new Random();
                var a = rnd.NextDouble() * 10;
                var c = rnd.NextDouble() * 10;

                foreach (var b in operation)
                {
                    var result = CalculateOperationSolver.Solve(a, b, c);

                    if (b == "+")  //a+c
                    {
                        Assert.AreEqual(a, result-c, 1e-10);
                    }
                    else if (b == "-") //a-c
                    {
                        Assert.AreEqual(a, result + c, 1e-10);
                    }
                    else if (b == "*") //a*c
                    {
                        Assert.AreEqual(a, result / c, 1e-10);
                    }
                    else if (b == "/")  // a/c
                    {
                        if (c != 0)
                            Assert.AreEqual(a, result * c, 1e-10);
                        else
                        {
                            Console.WriteLine("Деление на 0 невозможно! ");
                            Assert.AreEqual(0, result, 1e-10);
                        }
                    }
                    else if (b == "sqrt")
                    {
                        Assert.AreEqual(a, Math.Pow(result, 2.0), 1e-10);  //Math.Pow(a, 2.0);
                    }
                    else if (b == "square")
                    {
                        Assert.AreEqual(a, Math.Sqrt(result), 1e-10);
                    }
                    else if (b == "1/x")
                    {
                        Assert.AreEqual(1, result * a, 1e-10);
                    }

                }
            }
        }
    }   
}