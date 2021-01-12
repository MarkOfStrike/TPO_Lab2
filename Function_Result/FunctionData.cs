using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Equation_Library;

namespace Function_Result
{
    public class FunctionData
    {
        public static StringBuilder GetFunctionData(double x1, double x2, double step, Func<double, double> function)
        {
            StringBuilder result = new StringBuilder();

            for (var i = x1; i < x2; i+=step)
            {
                var num = Equation.ConvertRadiant(i);

                result.Append($"{i}|{function(num)}\n");
            }

            return result;
        }

        public static StringBuilder GetFunctionLog(double x1, double x2, double step, Func<double, double> function)
        {
            StringBuilder result = new StringBuilder();

            for (var i = x1; i < x2; i += step)
            {
                result.Append($"{i}|{function(i)}\n");
            }

            return result;
        }
    }

}
