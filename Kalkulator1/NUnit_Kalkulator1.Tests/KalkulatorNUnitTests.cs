using NUnit.Framework;
using Solver;

namespace NUnit_Kalkulator1.Tests
{
    [TestFixture]  // <= это называется атрибут.
                   // Таким атрибутом нужно пометить класс, чтобы система тестирования начала искать в нем тесты.
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]  // <= так нужно пометить метод, чтобы система тестирования поняла, что это тест.
        public void SingleTest()
        {
            var result = QuadraticEquationsSolver.Solve(1, -3, 2);
            Assert.AreEqual(2, result.Length);
        }

        [TestCase(1, -3, 2, 2, 1)]  // не нужно помечать атрибутом [Test]
        [TestCase(1, 1, 1)]  // каждый такой атрибут станет отдельным тестом
        [TestCase(2, 4, 2, -1)]
        public void TestCases(double a, double b, double c, params double[] expectedResult)
        {
            var result = QuadraticEquationsSolver.Solve(a, b, c);

            Assert.AreEqual(expectedResult.Length, result.Length);

            for (int i = 0; i < result.Length; i++)
                Assert.AreEqual(expectedResult[i], result[i]);
        }
    }
}