using System;

namespace T1_1
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
        }

        public static double Add(double first, double second) => first + second;
    }
}