using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    class Formula
    {
        public double IMC(double a, double b)
        {
            return ((a/2.205)/(b*b));
        }
    }
}
