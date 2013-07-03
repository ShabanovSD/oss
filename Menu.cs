using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integral
{
    class MyMenu
    {
        // вывод меню
        public void PrintMenu()
        {
            Console.WriteLine("Доступные функции:");

            Console.WriteLine("0: Выход из программы");

            Console.WriteLine("1: y = sin(x)");

            Console.WriteLine("2: y = x^2");

            Console.WriteLine("3: y = 2x");

            Console.WriteLine("4: y = 4*(x^0.5)");

            Console.WriteLine("5: y = 4.2*cos(x)");

            Console.WriteLine("6: y = -150*sin(x)");

            Console.WriteLine("7: y = 0.5*(x^3)");

            Console.WriteLine("8: y = Pi*cos(x)+3");

            Console.WriteLine("9: y = exp(-x)+2");

            Console.WriteLine("10: y = 2x+0.75");

            Console.WriteLine("11: y = Pi*arcsin(x)");

            Console.WriteLine("12: y = 15x-3");

            Console.WriteLine("13: y = log7(x)");

            Console.WriteLine("14: y = x+7");

            Console.WriteLine("15: y = sin(x^2)");
        }
        // запросить номер функции
        public int GetMenuChoice()
        {
            try
            {
                Console.WriteLine("Введите функцию:");
                return int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }

        }
        // запросить верхнюю границу
        public double GetTopBorder()
        {
            try
            {
                Console.WriteLine("Введите верхнюю границу интеграла:");
                return double.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }

        }
        // запросить нижнюю границу
        public double GetBottomBorder()
        {
            try
            {
                Console.WriteLine("Введите нижнюю границу интеграла границу интеграла:");
                return double.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }

        }
        /// <summary>
        /// Вывод результатов в консоль
        /// </summary>
        /// <param name="res1">результат методом левых прямоугольников</param>
        /// <param name="res2">результат методом правых прямоугольников</param>
        /// <param name="res3">результат методом средних прямоугольников</param>
        /// <param name="e1">погрешность лев. прям-ов</param>
        /// <param name="e2">погрешность пр-х. прям-ов</param>
        /// <param name="e3">погрешность ср-х. прям-ов</param>
        public void PrintResults(double res1, double res2, double res3, double e1, double e2, double e3)
        {
            Console.WriteLine("***** Результаты интегрирования *****");
            Console.WriteLine("Метод левых прямоугольников: " + res1 + " Погрешность: " + e1);
            Console.WriteLine("Метод правых прямоугольников: " + res2 + " Погрешность: " + e2);
            Console.WriteLine("Метод средних прямоугольников: " + res3 + " Погрешность: " + e3);
            Console.WriteLine("*************************************");
            Console.WriteLine();
        }

    }
}
