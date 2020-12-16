namespace Equation_Library
{
    public class Equation
    {
        public const double PI = 3.1415926535897931;

        /// <summary>
        /// Синус
        /// </summary>
        /// <param name="x">Угол, в радианах</param>
        /// <returns></returns>
        public static double Sin(double x)
        {
            int toch = 20;

            double result = 0;

            for (int i = 0; i < toch; i++)
            {
                result += (Pow(-1, i) * (Pow(x, (i * 2) + 1) / (Fact((i * 2) + 1))));
            }

            return result;
        }

        /// <summary>
        /// Косинус
        /// </summary>
        /// <param name="x">Угол в радианах</param>
        /// <returns></returns>
        public static double Cos(double x)
        {
            int toch = 20;

            double result = 0;

            for (int i = 0; i < toch; i++)
            {
                result += (Pow(-1, i) * (Pow(x, i * 2) / (Fact(i * 2))));
            }

            return result;
        }

        /// <summary>
        /// Факториал числа
        /// </summary>
        /// <param name="x">Целое число</param>
        /// <returns></returns>
        public static double Fact(int x)
        {
            if (x <= 1)
                return 1;

            return x * Fact(x - 1);
        }

        /// <summary>
        /// Тангенс
        /// </summary>
        /// <param name="x">Угол в радианах</param>
        /// <returns></returns>
        public static double Tan(double x)
        {
            return Sin(x) / Cos(x);
        }

        /// <summary>
        /// Котангенс
        /// </summary>
        /// <param name="x">угол в радианах</param>
        /// <returns></returns>
        public static double Cot(double x)
        {
            return 1 / Tan(x);
        }

        /// <summary>
        /// Логарифм числа по его основанию
        /// </summary>
        /// <param name="x">Число</param>
        /// <param name="y">Основание</param>
        /// <returns></returns>
        public static double Log(double x, double y)
        {
            return Ln(x) / Ln(y);
        }

        /// <summary>
        /// Натуральный логариф
        /// </summary>
        /// <param name="power">Число</param>
        /// <returns></returns>
        public static double Ln(double power)
        {
            if (power == 0)
                return double.NegativeInfinity;
            if (power == 1)
                return 0;
            if (power < 0)
                return double.NaN;

            const double e = 2.7182818284590451;
            var p = power;
            var n = 0.0;
            double a;

            // это ускоряет сходимость за счет вычисления интеграла
            while (p >= e)
            {
                p /= e;
                n++;
            }

            n += p / e;
            p = power;

            do
            {
                a = n;
                var l = p / Exp(n - 1.0);
                var r = (n - 1.0) * e;
                n = (l + r) / e;
            } while (Abs(n - a) > 0.001);

            return n;
        }

        /// <summary>
        /// Экспонента числа
        /// </summary>
        /// <param name="n">Степень</param>
        /// <returns></returns>
        public static double Exp(double n)
        {
            double x = n;
            double p = 1.0 + x;
            double fact = x;
            double i = 1.0;
            double l;

            do
            {
                i++;
                fact *= x / i;
                l = p;
                p += fact;
            } while (Abs(l - p) > 0.001);

            return p;
        }

        /// <summary>
        /// Десятичный логарифм
        /// </summary>
        /// <param name="n">Число</param>
        /// <returns></returns>
        public static double Lg(double num)
        {
            return Ln(num) / Ln(10d);
        }

        /// <summary>
        /// Возведение числа в степень
        /// </summary>
        /// <param name="num">Число</param>
        /// <param name="pow">Степень</param>
        /// <returns></returns>
        public static double Pow(double num, int pow)
        {
            if (pow == 0)
                return 1;

            var res = num;
            var absRadix = Abs(pow);

            for (int i = 1; i < absRadix; i++)
            {
                res *= num;
            }

            return pow > 0 ? res : 1 / res;
        }

        /// <summary>
        /// Квадратный корень числа
        /// </summary>
        /// <param name="x">Число</param>
        /// <returns></returns>
        public static double Sqrt(double x)
        {
            double s = 1.0;
            double l;

            do
            {
                l = x / s;
                s = (l + s) / 2;
            } while (Abs(l - s) > 0.000001);

            return s;
        }

        /// <summary>
        /// Модуль числа
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static double Abs(double num)
        {
            return num > 0 ? num : -num;
        }

        /// <summary>
        /// Конвертрование угла в радианы
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double ConvertRadiant(double value)
        {
            return value * PI / 180;
        }

        public static double Rounding(double x, int count)
        {
            if (count < 0)
            {
                //ошибка
            }

            if (count == 0)
            {
                return (int)x;
            }

            if (x.ToString().Contains(","))
            {
                var num = x.ToString();

                if (count >= num.Substring(num.IndexOf(",") + 1).Length)
                {
                    return x;
                }

                return double.Parse(x.ToString().Substring(0, x.ToString().IndexOf(",") + 1 + count));
            }
            else
            {
                return x;
            }
        }
    }
}
