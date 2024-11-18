using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ClassLab1
    {
        public double Expression(double a, double x, double y)
        {
            return 3 * x - (3 * x + a - 4 * a) / (3 * a + 2 * x + 6 * y) + ((a * x) / y + a / 2) / (3 * a / x) + 2 * x; 
        }
        public double Expression1(double a, double x, double y)
        {
            return 4 * x + ((2 + y + x - 3 * a) / (x - 7 * y)) - (a / y / 3 * a / x);
        }
    }
}
