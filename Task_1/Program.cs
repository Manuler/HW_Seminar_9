/*
 * Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
 * в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ReturnNumbersFrom1ToN(n));
        }

        static string ReturnNumbersFrom1ToN(int n)
        {
            string result = String.Empty;
            result = result + Convert.ToString(n) + result + " ";
            if (n == 1)
            {
                return result;  
            }
            else
            {
                return result + ReturnNumbersFrom1ToN(n - 1);
            }
        }
    }
}