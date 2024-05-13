using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 6, 4, 5, 22, 777, 9326, 2, 1, 53, 9999, 0, 2, 10, 22 };
            Console.WriteLine("введите число которое необходимо найти: ");
            int num = int.Parse(Console.ReadLine());
            bool TrueNum = false;
            number(num, myArray, TrueNum);
            
        }
         static void number(int num, int[] myArray,bool TrueNum)
        {
            for (int a = 0; a < myArray.Length; a++)
            {
                if (myArray[a] == num)
                {
                    Console.WriteLine("индекс вашего элемента в массиве: " + a);
                    TrueNum = true;
                    break;
                }
               
            }
            if (!TrueNum) Console.WriteLine("вашего элемента нет в массиве");
        }
    }
}
