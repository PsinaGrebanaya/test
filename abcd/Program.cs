using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace abcd
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
                } catch(Exception)
                {
                    Console.WriteLine("не удалось преобразовать стоку в число");
                    Console.ReadLine();
                    continue;
                }
            
                switch (Operation)
                {
                    case "+":
                        Console.WriteLine(firstNumber + " + " + SecondNumber + " = " + (firstNumber + SecondNumber));
                        break;
                    case "-":
                        Console.WriteLine(firstNumber + " - " + SecondNumber + " = " + (firstNumber - SecondNumber));
                        break;
                    case "/":
                        if (SecondNumber == 0) Console.WriteLine("на 0 делить нельзя");
                        else Console.WriteLine(firstNumber + " / " + SecondNumber + " = " + (firstNumber / SecondNumber));
                        break;
                    case "*":
                        Console.WriteLine(firstNumber + " * " + SecondNumber + " = " + (firstNumber * SecondNumber));
                        break;
                    case "%":
                        Console.WriteLine(firstNumber + " % " + SecondNumber + " = " + (firstNumber % SecondNumber));
                        break;
                    default:
                        Console.WriteLine("вы ввели несуществующую операцию");
                        break;
                }
                Console.ReadLine();
            }
         
        }
    }
}
