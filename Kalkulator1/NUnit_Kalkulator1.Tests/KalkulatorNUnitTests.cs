using NUnit.Framework;
using Solver;

namespace NUnit_Kalkulator1.Tests
{
    [TestFixture]  // <= ��� ���������� �������.
                   // ����� ��������� ����� �������� �����, ����� ������� ������������ ������ ������ � ��� �����.
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]  // <= ��� ����� �������� �����, ����� ������� ������������ ������, ��� ��� ����.
        public void SingleTest()
        {
            var result = QuadraticEquationsSolver.Solve(1, -3, 2);
            Assert.AreEqual(2, result.Length);
        }

        [TestCase(1, -3, 2, 2, 1)]  // �� ����� �������� ��������� [Test]
        [TestCase(1, 1, 1)]  // ������ ����� ������� ������ ��������� ������
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