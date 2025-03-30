namespace oop_lab2;

public class Circle :  Shape
{
    public double Radius{get;set;}
    public override double CalculateArea() => Radius * Radius * 3.14;
  
    
    public override void DisplayInfo() 
    { 
        Console.WriteLine("Circle");
       Console.WriteLine($"Radius: {Radius}");
       base.DisplayInfo();
    }

    public Circle(double radius)
    {
        Radius = radius;
    }
}