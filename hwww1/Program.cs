using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwww1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 3, 5, 1, 33 };
            DeleteLast(ref myArray);

        }
        static void DeleteEl(ref int[] arr, int index)
        {
            int[] newArray = new int[arr.Length - 1];
            if (index == arr.Length)
            {
                for (int i = 0; i < index - 1; i++)
                    newArray[i] = arr[i];
            }
            else
            {
                for (int i = 0; i < index; i++)
                    newArray[i] = arr[i];
            }
            for (int i = index; i < newArray.Length; i++)
                newArray[i] = arr[i + 1];
            arr = newArray;
            
        }
        static void DeleteFirst(ref int[] arr)
        {
            DeleteEl(ref arr, 0);
        }
        static void DeleteLast(ref int[] arr)
        {
            DeleteEl(ref arr, arr.Length);
        }
    }
}
