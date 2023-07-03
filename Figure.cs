namespace TestTask
{
    public abstract class Figure
    {
        private readonly double _area;
        public double Area => _area;
        protected Figure()
        {
            _area = CalculateArea();
        }
        protected abstract double CalculateArea();
    }
}