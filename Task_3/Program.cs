/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
 * Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/
namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine(AckermannFunction(m, n));
        }

        static int AckermannFunction(int m, int n)
        {
            if (m == 0) return n + 1;
            if (m != 0 && n == 0) return AckermannFunction(m - 1, 1);
            if (m > 0 && n > 0) return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        return AckermannFunction(m, n);
        }
    }
}