using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integral
{
    public class Inegrate
    {
        // делегат (указатель на функцию) которая принимает Х и возращает Y
        public delegate double Func(double x);
        /// <summary>
        /// Производит интегрирование заданой функции с задаными границами методом средних прямоугольников
        /// </summary>
        /// <param name="a">нижняя граница</param>
        /// <param name="b">верхняя граница</param>
        /// <param name="n">кол-во итераций</param>
        /// <param name="e">погрешность расчитывается внутри метода</param>
        /// <param name="Callback">функция от которой надо взять интеграл</param>
        /// <returns></returns>
        public double GetMiddleRectIntegrate(double a, double b, double n, ref double e, Func Callback)
        {
            double res=0.0, h;
            h = (b - a) / n;

            for (int i = 1; i <= n; i++)
            {
                res += Callback(a + h * (i - 0.5));
            }
            res *= h;
            e = Math.Pow(h,2);
            return res;
        }

        public double GetLeftRectIntegrate(double a, double b, double n, ref double e, Func Callback)
        {
            double res = 0.0, h;
            h = (b - a) / n;

            for (int i = 0; i < n; i++)
            {
                res += Callback(a + h * i);
            }
            res *= h;
            e = h;
            return res;
        }

        public double GetRightRectIntegrate(double a, double b, double n, ref double e, Func Callback)
        {
            double res = 0.0, h;
            h = (b - a) / n;

            for (int i = 1; i <= n; i++)
            {
                res += Callback(a + h * i);
            }
            res *= h;
            e = h;
            return res;
        }
    }
}
