using System;

namespace TestAppConsole
{
    class Program
    {
        private static MyMath myMath = new MyMath();
        static void Main(string[] args)
        {
            var a = myMath.Division(6, 0).GetType().Name;

            Console.WriteLine(a);
        }
    }
}
