using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLibrary
{
    internal class TriangleArea: IArea
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;
        public TriangleArea(double a, double b, double c)
        { 
            _a = a;
            _b = b;
            _c = c;
        }

        public double Calculate()
        {
            double result;
            if (Math.Pow(_a, 2) + Math.Pow(_b, 2) == Math.Pow(_c, 2))
            {
                result = CalcRightTriangle();
            }
            else
            {
                result = CalcTriangle();
            }

            return result;
        }

        private double CalcRightTriangle()
        {
            return 0.5 * (_a * _b);
        }

        private double CalcTriangle()
        {
            double p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }
    }
}
