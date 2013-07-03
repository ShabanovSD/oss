using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integral
{
    public static class FunctionSet
    {
        // статический класс с определениями всех 15-и функций
        /// <summary>
        ///  y = sin(x)
        /// </summary>
        public static double Fun1(double x)
        {
            return Math.Sin(x);
        }
        /// <summary>
        ///  y = x^2
        /// </summary>
        public static double Fun2(double x)
        {
            return x * x;
        }
        /// <summary>
        ///  y = 2x
        /// </summary>
        public static double Fun3(double x)
        {
            return 2*x;
        }
        /// <summary>
        ///  y = 4*(x^0.5)
        /// </summary>
        public static double Fun4(double x)
        {
            return 4 * Math.Pow(x, 0.5);
        }
        /// <summary>
        ///  y = 4.2*cos(x)
        /// </summary>
        public static double Fun5(double x)
        {
            return 4.2 * Math.Cos(x);
        }
        /// <summary>
        ///  y = -150*sin(x)
        /// </summary>
        public static double Fun6(double x)
        {
            return -150 * Math.Sin(x);
        }
        /// <summary>
        ///  y = 0.5*(x^3)
        /// </summary>
        public static double Fun7(double x)
        {
            return 0.5 * Math.Pow(x, 3);
        }
        /// <summary>
        ///  y = Pi*cos(x)+3
        /// </summary>
        public static double Fun8(double x)
        {
            return Math.PI * Math.Cos(x) + 3;
        }
        /// <summary>
        ///  y = exp(-x)+2
        /// </summary>
        public static double Fun9(double x)
        {
            return Math.Exp(-x) + 2;
        }
        /// <summary>
        ///  y = 2x+0.75
        /// </summary>
        public static double Fun10(double x)
        {
            return 2 * x + 0.75;
        }
        /// <summary>
        ///  y = Pi*arcsin(x)
        /// </summary>
        public static double Fun11(double x)
        {
            return Math.PI * Math.Asin(x);
        }
        /// <summary>
        ///  y = 15x-3
        /// </summary>
        public static double Fun12(double x)
        {
            return x * 15 - 3;
        }
        /// <summary>
        /// y = log7(x)
        /// </summary>>
        public static double Fun13(double x)
        {
            return Math.Log(x)/Math.Log(7);
        }
        /// <summary>
        ///  y = x+7
        /// </summary>
        public static double Fun14(double x)
        {
            return x + 7;
        }
        /// <summary>
        ///  y = sin(x^2)
        /// </summary>
        public static double Fun15(double x)
        {
            return Math.Sin(x * x);
        }
    }
}
