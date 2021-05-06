using System;
using FibonacciSeries;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FibonacciSeriesUnitTestProject
{
    [TestClass]
    public class FibonacciSeriesTest
    {
        /*
         To run the unit test case follow below steps:
         1. Click on test tab of visual studio.
         2. Click on Run from test dropdown
         3. Click on All Test or the kind of test case we need to run
         4. The results will be shown on output window, also we can see the result of test cases 
         on test explorer window
             */
        [TestMethod]
        public void FibonacciTest()
        {
            int length = 10;
            FibonacciSeriesProgram.Fibonacci(0, 1, 1, length);
        }
    }
}
