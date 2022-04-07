using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLibrary
{
    internal class CircleArea : IArea
    {
        private readonly double _radius;
        public CircleArea(double radius)
        {
            _radius = radius;
        }

        public double Calculate()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
