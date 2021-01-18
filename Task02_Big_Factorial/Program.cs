using System;
using System.Numerics;

namespace Task02_Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger nFactorial = 1;

            for (int i = 2; i <= n; i++)
            {
                nFactorial *= i;
            }
            
            Console.WriteLine(nFactorial);
        }
    }
}
