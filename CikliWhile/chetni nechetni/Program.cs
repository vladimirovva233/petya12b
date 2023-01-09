using System;

namespace chetni_nechetni
{
    class Program
    {
        static void Main(string[] args)
        {

            int BroiChetni = 0;
            int BroiNechetni = 0;
            int a = int.Parse(Console.ReadLine());
            while (a!=0)
            {
                if (a% 2 == 0)
                {
                    BroiChetni++;
                }
                else
                {
                    BroiNechetni++;
                }

            }
            Console.WriteLine($"Chetni={BroiChetni}");
            Console.WriteLine($"Nechetni={BroiNechetni}");
        }
    }
}
