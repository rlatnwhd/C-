using System.Threading.Channels;

class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public void set(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void showPoint()
    {
        Console.WriteLine("(" + X + "," + Y + ")");
    }
}
class ColorPoint : Point
{
    public string Color { get; set; }

    public void setColor(string color)
    {
        Color = color;
    }

    public void showColorPoint()
    {
        Console.Write(Color);
        showPoint();
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Point p = new Point();
        p.set(1, 2);
        p.showPoint();

        ColorPoint cp = new ColorPoint();
        cp.set(3, 4);
        cp.setColor("red");
        cp.showColorPoint();
    }
}