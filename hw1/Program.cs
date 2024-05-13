using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите символ: ");
            char sign = char.Parse(Console.ReadLine());
            Console.WriteLine("введите количество символов: ");
            int count = int.Parse(Console.ReadLine());
            Signs(count, sign);
            Console.WriteLine();
            Console.ReadLine();
        }
        static void Signs(int count, char sign)
        {
          for (int i = 0; i < count; i++)
            {
                Console.Write(sign);
            }   
        }
    }
}
