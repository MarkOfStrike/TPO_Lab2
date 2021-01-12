using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Equation_Library;

namespace Function_Result
{
    public class Function
    {
        public static double FunctionResult(double x)
        {
            if (x <= 0)
            {
                double radX = Equation.ConvertRadiant(x);
                double d = (Equation.Pow((((Equation.Cot(radX) + Equation.Tan(radX)) + Equation.Cot(radX))- (Equation.Cos(radX) - Equation.Cos(radX))),2) * Equation.Cos(radX));

                return d;
            }
            else
            {
                double r = (((((Equation.Lg(x) / Equation.Log(x, 5)) * Equation.Log(x, 2)) / Equation.Ln(x)) * Equation.Lg(x)) + (Equation.Log(x, 3) / Equation.Log(x, 2)));
                return r;
            }
        }

        public static double FunctionResultMath(double num)
        {
            

            if (num <= 0)
            {
                var x = Equation.ConvertRadiant(num);
                double d = (Math.Pow(((((1/Math.Tan(x)) + Math.Tan(x)) + (1 / Math.Tan(x))) - (Math.Cos(x) - Math.Cos(x))), 2) * Math.Cos(x));
                return d;
            }
            else
            {
                double r = (((((Math.Log10(num) / Math.Log(num, 5)) * Math.Log(num, 2)) / Math.Log(num)) * Math.Log10(num)) + (Math.Log(num, 3) / Math.Log(num, 2)));
                return r;
            }
        }

    }
}
