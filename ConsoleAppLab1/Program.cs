using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleAppLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("* Лабораторная работа #1 ");
            Console.WriteLine("* Вариант 4 ");
            Console.WriteLine("* Выполнил Бурков Виталий ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: ");
            Console.WriteLine("* Написать программу, которая вычисляет значение математического выражения по исходным данным, вводимых пользователем.");
            Console.WriteLine("* Выражение 1: 3 * x - (3 * x + a - 4 * a) / (3 * a + 2 * x + 6 * y) + ((a * x) / y + a / 2) / (3 * a / x) + 2 * x ");
            Console.WriteLine("* Выражение 2: 4 * x + ((2 + y + x - 3 * a) / (x - 7 * y)) - (a / y / 3 * a / x)");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: ");
            Console.WriteLine("* Введите значение X:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Введите значение Y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Введите значение A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ: ");
            ClassLab1 cl = new ClassLab1();
            Console.WriteLine(cl.Expression(a, x, y));
            Console.WriteLine(cl.Expression1(a, x, y));
            Console.ReadKey();
        }
    }
}
