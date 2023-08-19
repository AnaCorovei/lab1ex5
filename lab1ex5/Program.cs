using System;

namespace lab1ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ex5
            Se citesc doua numere de la tastatura, x,y. Scrieti un program care va afisa cele doua valori in ordine crescatoare.
            • Exemplu: citim ,9,0 Afisam : 0 9*/

            long x;
            long y;

            Console.WriteLine("Enter x: ");
            x = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter y: ");
            y = long.Parse(Console.ReadLine());


            if (x > y)
            Console.WriteLine("Ordinea crescatoare este: " + y + "," + x);
            else if (y > x)
                {
                Console.WriteLine("Ordinea crescatoare este: " + x + "," + y);
                }
            else if (x == y)
            {
                Console.WriteLine(x + "," + y);
            }

        }
    }
}
