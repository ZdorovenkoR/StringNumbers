using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и
//возвращающую число — сумму всех чисел в строке. Ввести данные с клавиатуры и вывести
//результат на экран.

namespace StringNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ряд чисел");
            var userNumbers = Console.ReadLine();
            Sum(SplitString(userNumbers));
            Console.ReadKey();
        }
        static void Sum(string [] array)
        {
            int sumSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sumSum += Convert.ToInt32(array[i]);
            }
            Console.WriteLine(sumSum);
        }    

        static string [] SplitString (string args)
        {
            return args.Split(' ');
        }
    }

}
