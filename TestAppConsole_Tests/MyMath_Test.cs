using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAppConsole;

namespace TestAppConsole_Tests
{
    [TestClass]
    public class MyMath_Test
    {
        private MyMath myMath;
        public MyMath_Test()
        {
            myMath = new MyMath();
        }


        [TestMethod]
        public void Addition_Test()
        {
            double x = 7;
            double y = 7;

            double exp = 14;
            double real = myMath.Addition(x, y);

            Assert.AreEqual(exp, real);
        }

        [TestMethod]
        public void Division_Exc_Test()
        {
            double x = 7;
            double y = 0;

            Assert.ThrowsException<DivideByZeroException>(new Action(() => myMath.Division(x, y)));
        }
        [TestMethod]
        public void Division_Val_Test()
        {
            double x = 7;
            double y = 7;

            double exp = 1;

            Assert.AreEqual(exp, myMath.Division(x, y));
        }

        [TestMethod]
        public void Subtraction_Test()
        {
            double x = 7;
            double y = 3;

            double exp = 4;
            double real = myMath.Subtraction(x, y);

            Assert.AreEqual(exp, real);
        }

        [TestMethod]
        public void Multiplication_Test()
        {
            double x = 7;
            double y = 7;

            double exp = 49;
            double real = myMath.Multiplication(x, y);

            Assert.AreEqual(exp, real);
        }

        [TestMethod]
        public void Sum_squared_Test()
        {
            int a = 5;
            int b = 9;

            int exp = 12;
            int real = myMath.Sum_squared(a, b);

            Assert.AreEqual(exp, real);
        }
    }
}