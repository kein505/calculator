using NUnit.Framework;
using Solver;

namespace NUnit_Kalkulator1.Tests
{
    [TestFixture] // <= ��� ���������� �������.
    // ����� ��������� ����� �������� �����, ����� ������� ������������ ������ ������ � ��� �����.
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test] // <= ��� ����� �������� �����, ����� ������� ������������ ������, ��� ��� ����.
        public void SingleTest()
        {
            var result = QuadraticEquationsSolver.Solve(1, -3, 2);
            Assert.AreEqual(2, result.Length);
        }

        [TestCase(1, -3, 2, 2, 1)] // �� ����� �������� ��������� [Test]
        [TestCase(1, 1, 1)] // ������ ����� ������� ������ ��������� ������
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

        [Test] // <= ��� ����� �������� �����, ����� ������� ������������ ������, ��� ��� ����.
        public void Negative_Test()
        {
            var result = CalculateOperationSolver.Solve(1, "g", 2);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Negative_DelenieNaNull_Test()
        {
            var result = CalculateOperationSolver.Solve(1, "/", 0);
            string expectedResult = "�������������";
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(1, "+", 2, 3)]
        [TestCase(3, "-", 2, 1)]
        [TestCase(1, "*", 2, 2)]
        [TestCase(1, "/", 2, 0.5)]
        [TestCase(16, "sqrt", 2, 4)]
        public void Pasitive_TestCases(double a, string b, double c, double expectedResult)
        {
                var result = CalculateOperationSolver.Solve(a, b, c);

                Assert.AreEqual(expectedResult, result);

                //for (int i = 0; i < result.Length; i++)
                //    Assert.AreEqual(expectedResult[i], result[i]);
        }

        [TestCase("q", "/", 2, 0)]
       // [TestCase(16, "/", 0, "�������������")]
        public void Negative_TestCases(double a, string b, double c, double expectedResult)
        {
            var result = CalculateOperationSolver.Solve(a, b, c);

            Assert.AreEqual(expectedResult, result);
        }
    }   
}