using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integral
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            const int n = 100;  // количество шагов интегрирования
            double bottom = 0,  // нижняя граница интеграла
                top = 0;        // верхняя граница интеграла
            int choise = 0;     // переменная определяет какой пункт меню выбран
            double res1 = 0,    // результат методом левых прямоугольников
                res2 = 0,       // результат методом правых прямоугольников
                res3 = 0;       // результат методом средних прямоугольников
            double e1 = 0,      // погрешность лев. прям-ов
                e2 = 0,         // погрешность прв. прям-ов
                e3 = 0;         // погрешность срд. прям-ов
            Inegrate Integral = new Inegrate(); // обьект с методами интегрирования
            MyMenu menu = new MyMenu();         // объект с методами вывода меню и результатов
            #endregion

            while (true)
            {
                menu.PrintMenu();                   // вывод мен.
                choise = menu.GetMenuChoice();      // запрашиваем пункт меню у пользователя
                if (choise == 0)
                {
                    System.Environment.Exit(-1);    // выход из программы если выбран 0 пункт меню
                }
                bottom = menu.GetBottomBorder();    // запрашиваем ниж. границу
                top = menu.GetTopBorder();          // запрашиваем вер. границу

                #region Function choise
                switch (choise)
                {
                    case 1:
                        res1 = Integral.GetLeftRectIntegrate(bottom, top, n, ref e1, FunctionSet.Fun1);
                        res2 = Integral.GetRightRectIntegrate(bottom, top, n, ref e2, FunctionSet.Fun1);
                        res3 = Integral.GetMiddleRectIntegrate(bottom, top, n, ref e3, FunctionSet.Fun1);
                        break;
                    case 2:
                        res1 = Integral.GetLeftRectIntegrate(bottom, top, n, ref e1, FunctionSet.Fun2);
                        res2 = Integral.GetRightRectIntegrate(bottom, top, n, ref e2, FunctionSet.Fun2);
                        res3 = Integral.GetMiddleRectIntegrate(bottom, top, n, ref e3, FunctionSet.Fun2);
                        break;
                    case 3:
                        res1 = Integral.GetLeftRectIntegrate(bottom, top, n, ref e1, FunctionSet.Fun3);
                        res2 = Integral.GetRightRectIntegrate(bottom, top, n, ref e2, FunctionSet.Fun3);
                        res3 = Integral.GetMiddleRectIntegrate(bottom, top, n, ref e3, FunctionSet.Fun3);
                        break;
                    case 4:
                        res1 = Integral.GetLeftRectIntegrate(bottom, top, n, ref e1, FunctionSet.Fun4);
                        res2 = Integral.GetRightRectIntegrate(bottom, top, n, ref e2, FunctionSet.Fun4);
                        res3 = Integral.GetMiddleRectIntegrate(bottom, top, n, ref e3, FunctionSet.Fun4);
                        break;
                    case 5:
                        res1 = Integral.GetLeftRectIntegrate(bottom, top, n, ref e1, FunctionSet.Fun5);
                        res2 = Integral.GetRightRectIntegrate(bottom, top, n, ref e2, FunctionSet.Fun5);
                        res3 = Integral.GetMiddleRectIntegrate(bottom, top, n, ref e3, FunctionSet.Fun5);
                        break;
                    case 6:
                        res1 = Integral.GetLeftRectIntegrate(bottom, top, n, ref e1, FunctionSet.Fun6);
                        res2 = Integral.GetRightRectIntegrate(bottom, top, n, ref e2, FunctionSet.Fun6);
                        res3 = Integral.GetMiddleRectIntegrate(bottom, top, n, ref e3, FunctionSet.Fun6);
                        break;
                    case 7:
                        res1 = Integral.GetLeftRectIntegrate(bottom, top, n, ref e1, FunctionSet.Fun7);
                        res2 = Integral.GetRightRectIntegrate(bottom, top, n, ref e2, FunctionSet.Fun7);
                        res3 = Integral.GetMiddleRectIntegrate(bottom, top, n, ref e3, FunctionSet.Fun7);
                        break;
                    case 8:
                        res1 = Integral.GetLeftRectIntegrate(bottom, top, n, ref e1, FunctionSet.Fun8);
                        res2 = Integral.GetRightRectIntegrate(bottom, top, n, ref e2, FunctionSet.Fun8);
                        res3 = Integral.GetMiddleRectIntegrate(bottom, top, n, ref e3, FunctionSet.Fun8);
                        break;
                    case 9:
                        res1 = Integral.GetLeftRectIntegrate(bottom, top, n, ref e1, FunctionSet.Fun9);
                        res2 = Integral.GetRightRectIntegrate(bottom, top, n, ref e2, FunctionSet.Fun9);
                        res3 = Integral.GetMiddleRectIntegrate(bottom, top, n, ref e3, FunctionSet.Fun9);
                        break;
                    case 10:
                        res1 = Integral.GetLeftRectIntegrate(bottom, top, n, ref e1, FunctionSet.Fun10);
                        res2 = Integral.GetRightRectIntegrate(bottom, top, n, ref e2, FunctionSet.Fun10);
                        res3 = Integral.GetMiddleRectIntegrate(bottom, top, n, ref e3, FunctionSet.Fun10);
                        break;
                    case 11:
                        res1 = Integral.GetLeftRectIntegrate(bottom, top, n, ref e1, FunctionSet.Fun11);
                        res2 = Integral.GetRightRectIntegrate(bottom, top, n, ref e2, FunctionSet.Fun11);
                        res3 = Integral.GetMiddleRectIntegrate(bottom, top, n, ref e3, FunctionSet.Fun11);
                        break;
                    case 12:
                        res1 = Integral.GetLeftRectIntegrate(bottom, top, n, ref e1, FunctionSet.Fun12);
                        res2 = Integral.GetRightRectIntegrate(bottom, top, n, ref e2, FunctionSet.Fun12);
                        res3 = Integral.GetMiddleRectIntegrate(bottom, top, n, ref e3, FunctionSet.Fun12);
                        break;
                    case 13:
                        res1 = Integral.GetLeftRectIntegrate(bottom, top, n, ref e1, FunctionSet.Fun13);
                        res2 = Integral.GetRightRectIntegrate(bottom, top, n, ref e2, FunctionSet.Fun13);
                        res3 = Integral.GetMiddleRectIntegrate(bottom, top, n, ref e3, FunctionSet.Fun13);
                        break;
                    case 14:
                        res1 = Integral.GetLeftRectIntegrate(bottom, top, n, ref e1, FunctionSet.Fun14);
                        res2 = Integral.GetRightRectIntegrate(bottom, top, n, ref e2, FunctionSet.Fun14);
                        res3 = Integral.GetMiddleRectIntegrate(bottom, top, n, ref e3, FunctionSet.Fun14);
                        break;
                    case 15:
                        res1 = Integral.GetLeftRectIntegrate(bottom, top, n, ref e1, FunctionSet.Fun15);
                        res2 = Integral.GetRightRectIntegrate(bottom, top, n, ref e2, FunctionSet.Fun15);
                        res3 = Integral.GetMiddleRectIntegrate(bottom, top, n, ref e3, FunctionSet.Fun15);
                        break;
                    default: break;
                }
                #endregion

                menu.PrintResults(res1, res2, res3, e1, e2, e3);    // выводим результаты
            }
        }
    }
}
