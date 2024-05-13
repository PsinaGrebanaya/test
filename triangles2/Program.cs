using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangles2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите высоту треугольника");
            int Heigth = int.Parse(Console.ReadLine());
            for (int i = 0; i < Heigth; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < Heigth; i++)
            {
                for (int j = Heigth; j > i; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < Heigth; i++)
            {
                for (int j = Heigth; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < Heigth; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = Heigth; j > i; j--)
                {
                    Console.Write("#");                   
                }
                Console.WriteLine();
            }
        }
    }
}
