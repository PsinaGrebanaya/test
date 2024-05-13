using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int k = 9;
            int b = 9;
            
            
            for (int j = 0; j < 10; j++)
            {
                for (; k < 10; k++)
                {
                    Console.Write("#");

                }
                k = 9;
                j++;
                k -= j;
                j--;
                Console.WriteLine();

            }
            Console.WriteLine();
            k = 0;
            for (int j = 0; j < 10; j++)
            {
                for (; k < 10; k++)
                {
                    Console.Write("#");

                }
                k -= 10;
                j++;
                k += j;
                j--;
                Console.WriteLine();

            }
            Console.WriteLine();
            k = 0;
            for (int j = 0; j < 10; j++)
            {
                for (; k < 10; k++)
                {
                    for (; k<b; k++)
                    {
                       Console.Write(" ");
                    }
                    Console.Write("#");
                }
                k = 0;
                b--;
               
                Console.WriteLine();

            }
            Console.WriteLine();
            k = 0;
            b = 0;
            for (int j = 0; j < 10; j++)
            {
                for (; k < 10; k++)
                {
                    for (; k < b; k++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("#");
                }
                k = 0;
                b++;

                Console.WriteLine();

            }

            Console.ReadLine();
        }
    }
}
