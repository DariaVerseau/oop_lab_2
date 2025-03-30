namespace oop_lab2;

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public override double CalculateArea() => Width * Height;

    public override void DisplayInfo()
    {
        Console.WriteLine("Rectangle");
        Console.WriteLine($"Width: {Width}, Height: {Height}");
        base.DisplayInfo();
    }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
}