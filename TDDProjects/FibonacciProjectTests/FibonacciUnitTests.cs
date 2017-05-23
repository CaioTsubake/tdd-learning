using System;
using FibonacciProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FibonacciProjectTests
{
    [TestClass]
    public class FibonacciUnitTests
    {
        [TestMethod]
        public void Fib_Given0_Return0()
        {
            int n = 0;

            int result = Fibonacci.Fib(n);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Fib_Given1_Return1()
        {
            //Assert
            int n = 1;

            //Act
            int result = Fibonacci.Fib(n);

            //Assert
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void Fib_Given2_Return1()
        {
            //Assert
            int n = 2;

            //Act
            int result = Fibonacci.Fib(n);

            //Assert
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void Fib_Given3_Return2()
        {
            //Assert
            int n = 3;

            //Act
            int result = Fibonacci.Fib(n);

            //Assert
            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void Fib_Given4_Return3()
        {
            //Assert
            int n = 4;

            //Act
            int result = Fibonacci.Fib(n);

            //Assert
            Assert.AreEqual(result, 3);
        }
    }
}
