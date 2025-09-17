using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LernArray
{
    public class LaboratoryWork
    {
        /*Задача: напишите программу на C#, которая вычисляет сумму двух заданных целочисленных значений. 
                  Если два заданных значения равны, то вернуть двойную сумму.*/

        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");

            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");

            int num2 = int.Parse(Console.ReadLine());


            int res = num1 + num2;

            if (num1 == num2)
            {
                int v = res * 2;
                Console.WriteLine($"Ответ равен: {v}");
            }

            Console.ReadKey();

        }


    }
}

