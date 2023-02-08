using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int deca = int.Parse(Console.ReadLine());
            int nadbavka = 0;
            if (deca > 2)
            {
                nadbavka = deca * 40;
            }
            else
            {
                nadbavka = deca * 30;
            }
            Console.WriteLine(nadbavka);
        }
    }
}
