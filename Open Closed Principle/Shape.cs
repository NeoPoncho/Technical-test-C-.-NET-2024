namespace Open_Closed_Principle
{
    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Rectangle(double width, double height) : Shape
    {
        public double Width { get; set; } = width;
        public double Height { get; set; } = height;

        public override double Area() => Width * Height;
    }
}