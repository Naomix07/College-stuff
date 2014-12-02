using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3progr3functii
{
    class Program
    {
        static void Cerinta1(int n)
        {
            int y, j, z;

            y = 1;
            z = 1;

            do
            {
                for (j = y; j <= z; j++)

                    Console.Write("{0} ", j);
                Console.Write("\n");

                y++;
                z = z + 2;

            } while (z <= n * 2 - 1);
        }

        static void Cerinta2(int n)
        {
            int z, y, j;

            y = 0;
            z = 1;

            do
            {
                for (j = 1; j <= z; j++)
                    if (y < n)
                    {
                        Console.Write("{0} ", j);
                        y++;
                    }
                    else z = n;
                z++;

            } while (z <= n);
        }

        static void Cerinta3(int n)
        {
            int y, j, z, x = 0;

            y = 1;
            z = 1;

            do
            {
                for (j = y; j <= z; j++)
                    if (x < n)
                    {
                        Console.Write("{0} ", j);
                        x++;
                    }
                    else x = n * 2;

                y++;
                z = z + 2;

            } while (z <= n * 2 - 1);
        }

        static void Main(string[] args)
        {
            int n;

            n = int.Parse(args[0]);

            Console.WriteLine("Rezolvarea cerintei 1 arata astfel:");
            Cerinta1(n);
            Console.WriteLine("\n Rezolvarea cerintei 2 arata astfel:");
            Cerinta2(n);
            Console.WriteLine("\n\n Rezolvarea cerintei 3 arata astfel:");
            Cerinta3(n);
            Console.Read();

        }
    }
}
