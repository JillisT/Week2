using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {

            //int macht = 2;
            //for (int i = 1; i <= 10; i++) 
            //{
            //    Console.WriteLine(Math.Pow(macht,i)); 
            //}
            //Console.ReadKey();

            //int macht = 2;
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(Math.Pow(macht, i));
            //    i++;
            //}
            //Console.ReadKey();

            //int macht = 2;
            //int i = 1;
            //do
            //{
            //    Console.WriteLine(Math.Pow(macht, i));
            //    i++;
            //} while (i <= 10);
            //Console.ReadKey();

            //Console.WriteLine("Voer 5 getalen in");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //int d = Convert.ToInt32(Console.ReadLine());
            //int e = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Het grootste getal is: " + Math.Max(a, Math.Max(b, Math.Max(c, Math.Max(d, e)))));
            //Console.ReadKey();
            //Console.Clear();


            //int f1 = 0;
            //int f2 = 1;

            //for (int i = 0; i < 15; i++)
            //{
            //    Console.WriteLine(f1);
            //    int fn = f1;
            //    f1 = f2;
            //    f2 = fn + f2;
            //}

            //Console.ReadKey();

            //Opdracht C
            Console.Clear();
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    if ((x + y) % 2 == 0)
                    {
                        if ((x * y) <= 25)
                        {
                            Console.Write("-");
                        }
                        else
                            break;
                    }
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
