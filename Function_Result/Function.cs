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

    }
}
