using System;

namespace TestAppConsole
{
    public class MyMath
    {
        public double Addition(double x, double y) => x + y;

        public double Subtraction(double x, double y) => x - y;

        public double Division(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            return x / y;
        }

        public double Multiplication(double x, double y) => x * y;

        public int Sum_squared(int a, int b) => (a + b) ^ 2;
    }
}