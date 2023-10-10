using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ZhdanovaAA.Sprint1.TaskReview.V20.Lib
{
    public class DataService
    {
        public double Calculate(double x, double y)
        {
            return Math.Round((2 + Math.Pow(Math.Cos(x + y), 2)) / (1 + Math.Abs(x - ((3 * x) / (1 + Math.Pow(x, 2) * Math.Pow(y, 2))))) + x * y, 3);
        }
    }
}
