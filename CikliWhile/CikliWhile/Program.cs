using System;

namespace CikliWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            int a = int.Parse(Console.ReadLine());
            while (a!=0)
            {
                s += a;
                a = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Suma = " + s);
        }
    }
}
