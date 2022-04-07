namespace AreaLibrary
{
    public class CalcArea
    {
        public double Calculate(double radius)
        { 
            IArea area = new CircleArea(radius);
            return area.Calculate(); 
        }

        public double Calculate(double a, double b, double c)
        { 
            IArea area = new TriangleArea(a, b, c);
            return area.Calculate();
        }
    }
}