using System;

namespace Uppgift_4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ut sidlängden för en triangel");
            int sidLängd = int.Parse(Console.ReadLine());

            for (int i = 0; i <sidLängd; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
            }
            Console.ReadKey();
        }
    }
}