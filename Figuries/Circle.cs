
namespace TestTask.Figuries
{
    public class Circle : Figure
    {
        private double _radius;
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException("Недопустимое значение радиуса");

            _radius = radius;
        }
        protected sealed override double CalculateArea()
        {
            return _radius * _radius * Math.PI;
        }
    }
}
