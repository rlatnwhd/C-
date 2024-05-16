using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

abstract class Shape
{
    public abstract double CalculateArea();

    public void Display()
    {
        Console.WriteLine("This is a shape");
    }

    
}
class Circle : Shape
{
    public double R { get; set; }
    public override double CalculateArea()
    {
        return Math.PI*R*R;
    }
    public Circle(double radius)
    {
        R = radius;
    }
}

class Rectangle : Shape
{
    public double W { get; set; }
    public double H { get; set; }
    public override double CalculateArea()
    {
        return H*W;
    }

    public Rectangle(double height, double width)
    {
        H = height;
        W = width;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("반지름 입력 : ");
        int radius = int.Parse(Console.ReadLine());
        Circle c = new Circle(radius);
        c.Display();
        Console.WriteLine("Circle Area : " + c.CalculateArea().ToString("0.00"));

        Console.Write("가로 입력 : ");
        int width = int.Parse(Console.ReadLine());
        Console.Write("세로 입력 : ");
        int height = int.Parse(Console.ReadLine());
        Rectangle r = new Rectangle(width, height);
        r.Display();
        Console.WriteLine("Rectangle Area : " + r.CalculateArea());
    }
}