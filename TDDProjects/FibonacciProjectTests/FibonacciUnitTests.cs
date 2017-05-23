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

            //Act
            int result = FibonacciSetup(0);

            //Assert
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void Fib_Given1_Return1()
        {
            //Act
            int result = FibonacciSetup(1);

            //Assert
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void Fib_Given2_Return1()
        {
            //Act
            int result = FibonacciSetup(2);

            //Assert
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void Fib_Given3_Return2()
        {
            //Act
            int result = FibonacciSetup(3);

            //Assert
            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void Fib_Given4_Return3()
        {
            //Act
            int result = FibonacciSetup(4);

            //Assert
            Assert.AreEqual(result, 3);
        }

        public int FibonacciSetup(int n)
        {
            int result = Fibonacci.Fib(n);

            return result;
        }
    }
}
