using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massive3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Value = 0;
            Console.Write("введите длинну массива");
            int longMassive = int.Parse(Console.ReadLine());
            int[] myArray = new int[longMassive];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("введите значение элемента массива под индексом " + i + ": ");
                myArray[i] = int.Parse(Console.ReadLine());
                if (myArray[i] % 2 == 0) Value += myArray[i];
            }
            Console.WriteLine("сумма четных чисел в вашем массиве = " + Value);

            Console.ReadLine();
        }
    }
}
