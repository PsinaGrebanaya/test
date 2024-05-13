using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massive1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите длинну массива: ");
            int longMassive = int.Parse(Console.ReadLine());
            int[] myArray = new int[longMassive];
            for (int i = 0; i < myArray.Length; i++) 
            {
                Console.Write("введите значение элемента массива под индексом " + i + ": ");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("ваш массив:");
            for (int i = 0;i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            Console.ReadLine();
        }
    }
}
