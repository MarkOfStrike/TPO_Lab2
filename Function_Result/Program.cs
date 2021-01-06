using System;

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
            Console.ReadKey();
        }

    }
}
