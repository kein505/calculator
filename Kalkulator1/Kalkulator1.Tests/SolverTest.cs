﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solver;

namespace Kalkulator1.Tests
{
    [TestClass]
    public class SolverTest
    {
        void TestEquation(double a, double b, double c, params double[] expectedResult)
        {
            var result = QuadraticEquationsSolver.Solve(a, b, c);
            Assert.AreEqual(expectedResult.Length, result.Length);

            for(int i=0; i<result.Length; i++)
                Assert.AreEqual(expectedResult[i], result[i]);
        }

        [TestMethod]
        public void OrdinaryEquation()
        {
            TestEquation(1, -3, 2, 2, 1);
        }

        [TestMethod]
        public void NegativeDescriminant()
        {
            TestEquation(1, 1, 1);
        }
        [TestMethod]
        public void ZeroDiscriminant()
        {
            TestEquation(1, 2, 1, -1);
        }
        [TestMethod]
        public void FunctionTest()
        {
            for (int i = 0; i < 100; i++)
            {
                var rnd = new Random();
                var a = rnd.NextDouble() * 10;
                var b = rnd.NextDouble() * 10;
                var c = rnd.NextDouble() * 10;
                var result = QuadraticEquationsSolver.Solve(a, b, c);
                foreach (var x in result)
                {
                    Assert.AreEqual(0, a * x * x + b * x + c, 1e-10);

                }
            }
        }
    }
}
