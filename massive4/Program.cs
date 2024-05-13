using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massive4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("введите длинну массива");
            int longMassive = int.Parse(Console.ReadLine());
            int[] myArray = new int[longMassive];
            int lowNum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("введите значение элемента массива под индексом " + i + ": ");
                myArray[i] = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    lowNum = myArray[i];
                    continue;
                }
                if (lowNum > myArray[i]) lowNum = myArray[i];

            }
            Console.WriteLine("наименьшее число в вашем массиве = " + lowNum);

            Console.ReadLine();
        }
    }
}
