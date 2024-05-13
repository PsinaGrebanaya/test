using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massive2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("напишите число: ");
            string count = Console.ReadLine();
            int result = ConvertToInt(count);
            Console.WriteLine("сумма цифр в числе:" + result);
            Console.ReadLine();
        }
        static int ConvertToInt(string count, int i = 0)
        {
         if (i >= count.Length)
            {
                return 0;
            }
            int[] arr = new int[count.Length];
            string letter = Convert.ToString(count[i]);
            arr[i] = int.Parse(letter);
            return arr[i] + ConvertToInt(count, i + 1);
        }
    }
}
