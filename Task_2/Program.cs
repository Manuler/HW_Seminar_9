/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
 * в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

using System.Diagnostics.CodeAnalysis;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ReturnNumbersFromMtoN(m, n));
        }
        static int ReturnNumbersFromMtoN(int m, int n)
        {
            int sum = 0;
            if (m == n)
            {
                return sum + m;
            }
            else
            {
                sum = sum + n;
                return sum + ReturnNumbersFromMtoN(m, n-1);
            }
        }
    }
}