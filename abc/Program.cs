using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, SecondNumber;
            String Operation;
            while (true)
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("Напишите первое число");
                    firstNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine("введите арифметическую операцию");
                    Operation = Console.ReadLine();
                    Console.WriteLine("введите второе число");
                    SecondNumber = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("не удалось преобразовать стоку в число");
                    Console.ReadLine();
                    continue;
                }
                if (Operation == "+")
                {
                    Console.WriteLine(firstNumber + " + " + SecondNumber + " = " + (firstNumber + SecondNumber));
                }
                else if (Operation == "-")
                {
                    Console.WriteLine(firstNumber + " - " + SecondNumber + " = " + (firstNumber - SecondNumber));
                }
                else if (Operation == "/")
                {
                    if (SecondNumber == 0) Console.WriteLine("на 0 делить нельзя");
                     else Console.WriteLine(firstNumber + " / " + SecondNumber + " = " + (firstNumber / SecondNumber));
                }
                else if (Operation == "*")
                {
                    Console.WriteLine(firstNumber + " * " + SecondNumber + " = " + (firstNumber * SecondNumber));
                }
                else if (Operation == "%")
                {
                    Console.WriteLine(firstNumber + " % " + SecondNumber + " = " + (firstNumber % SecondNumber));
                }
                else
                {
                    Console.WriteLine("вы ввели несуществующую операцию");
                }
                Console.ReadLine();
            }
        }
    }
}
