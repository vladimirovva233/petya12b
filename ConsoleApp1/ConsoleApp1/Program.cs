using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("adult");
            }
            else 
            {
                Console.WriteLine("child");
            }
        }
    }
}
