using System;

namespace FactorialRec
{
    class Program
    {
        static int Fact(int n)
        {
            if (n <= 0) return 1;

            return n * Fact(n-1);
        }
        static int Fibonacci(int n)
        {
            if (n <= 1) return n;

            return  Fibonacci(n-1) + Fibonacci(n-2);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           // int res = Fact(n);
          //  Console.WriteLine(res);
            int resFib = Fibonacci(n);
            Console.WriteLine(resFib);
        }
    }
}
