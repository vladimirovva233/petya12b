using System;

namespace pej_sio
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            int a;
            do
            {
                a = int.Parse(Console.ReadLine());
                s += a;
            } while (a != 0);
            Console.WriteLine($"Suma={s}");
             
        }
    }
}
