using System;
using System.IO;
using System.Text;

using Equation_Library;

namespace Function_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 0;

            do
            {
                Console.Write("Введите число: ");
            } while (!double.TryParse(Console.ReadLine(), out number));

            Console.WriteLine($"Результат: {Function.FunctionResult(number)}");

            Console.WriteLine("Выгрузка данных:");
            Console.WriteLine("1. Sin\n" +
                "2. Cos\n" +
                "3. Tan\n" +
                "4. Cot");
            Console.Write("Введите выбранный пункт: ");
            int.TryParse(Console.ReadLine(), out int num);

            Console.Write("Введите начальное значение: ");
            double.TryParse(Console.ReadLine(), out double x1);

            Console.Write("Введите конечное значение: ");
            double.TryParse(Console.ReadLine(), out double x2);

            Console.Write("Введите шаг: ");
            double.TryParse(Console.ReadLine(), out double step);

            StringBuilder str = new StringBuilder();
            string fileName = "";
            switch (num)
            {
                case 1:
                    str = FunctionData.GetFunctionData(x1, x2, step, Equation.Sin);
                    fileName = "Sin";
                    break;
                case 2:
                    str = FunctionData.GetFunctionData(x1, x2, step, Equation.Cos);
                    fileName = "Cos";
                    break;
                case 3:
                    str = FunctionData.GetFunctionData(x1, x2, step, Equation.Tan);
                    fileName = "Tan";
                    break;
                case 4:
                    str = FunctionData.GetFunctionData(x1, x2, step, Equation.Cot);
                    fileName = "Cot";
                    break;

                default:
                    break;
            }

            using (var sw = new StreamWriter($"{Directory.GetCurrentDirectory()}/{fileName}.csv", false, Encoding.Default))
            {
                sw.WriteLine(str.ToString());
                sw.Close();
            }

            Console.ReadKey();
        }

    }
}
