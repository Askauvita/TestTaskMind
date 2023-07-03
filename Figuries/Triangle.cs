
namespace TestTask.Figuries
{
    public class Triangle : Figure
    {
        public double FirstSide;
        public double SecondSide;
        public double ThirdSide;
        public bool _isRectangular;
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0
                || (firstSide + secondSide - thirdSide <= 0.0)
                || (firstSide + thirdSide - secondSide <= 0.0)
                || (thirdSide + secondSide - firstSide <= 0.0))
                    throw new ArgumentOutOfRangeException("Недопустимое значение одной из сторон"); 

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
            _isRectangular = IsRectangular(FirstSide, SecondSide, ThirdSide);
        }
        protected sealed override double CalculateArea()
        {
            var perimeter = (FirstSide + SecondSide + ThirdSide) / 2.0;
            return Math.Sqrt(perimeter * (perimeter - FirstSide) * (perimeter - SecondSide) * (perimeter - ThirdSide));
        }
        private bool IsRectangular(double firstSide, double secondSide, double thirdSide)
        {
            var maxSide = new double[] { firstSide, secondSide, thirdSide }.Max();
            return 2 * Math.Pow(maxSide, 2) == Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2);
        }
    }
}
