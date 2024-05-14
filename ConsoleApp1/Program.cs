using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int even = 0;
            int odd = 0;
            int diapozone1, diapozone2;
            while (true)
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("введите перове число");
                    diapozone1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("введите второе число");
                    diapozone2 = int.Parse(Console.ReadLine());
                } catch (Exception)
                {
                    Console.WriteLine("не удалось преобразовать строку в число");
                    Console.ReadLine();
                    continue;
                }
                
                while (diapozone1 <= diapozone2)
                {
                    if (diapozone1 % 2 == 0) even++;
                    else odd++;
                    diapozone1++;
                }
                Console.WriteLine("чётных чисел " + even + ", нечётных " + odd);
                Console.ReadLine();
            }




        }
    }
}
