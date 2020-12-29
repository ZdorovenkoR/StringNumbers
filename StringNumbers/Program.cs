using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Написать метод GetFullName(string firstName, string lastName, string
//patronymic), принимающий на вход ФИО в разных аргументах и возвращающий
//объединённую строку с ФИО. Используя метод, написать программу, выводящую в консоль
//3–4 разных ФИО.
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
