namespace oop_lab2;

abstract public class Shape (): IShape
{
    public abstract double CalculateArea();

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Area: " + CalculateArea());
        Console.WriteLine();
    }
}