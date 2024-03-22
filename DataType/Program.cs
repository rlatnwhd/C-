internal class Program
{
    private static void Main(string[] args)
    {
        // long 자료형을 int 자료형으로 변환
        long longNumber = 2147483647L + 2147483647L;
        int longToInt = (int)longNumber;
        Console.WriteLine(longToInt);

        // long 자료형을 int 자료형으로 변환
        double doubleNumber = 52.27310332;
        int doubleToInt = (int)doubleNumber;
        Console.WriteLine(doubleToInt);

        Console.WriteLine(int.Parse("52"));
        Console.WriteLine(long.Parse("273"));
        Console.WriteLine(float.Parse("52.273"));
        Console.WriteLine(double.Parse("103.32"));
        Console.WriteLine(bool.Parse("true"));

        Console.WriteLine(int.Parse("52").GetType());
        Console.WriteLine(long.Parse("273").GetType());
        Console.WriteLine(float.Parse("52.273").GetType());
        Console.WriteLine(double.Parse("103.32").GetType()); 
        Console.WriteLine(bool.Parse("true").GetType());

        Console.WriteLine(52 + 273);
        Console.WriteLine("52" + 273);
        Console.WriteLine(52 + "273");
        Console.WriteLine("52" + "273");

        Console.WriteLine((52 + 273).GetType());
        Console.WriteLine(("52" + 273).GetType());
        Console.WriteLine((52 + "273").GetType());
        Console.WriteLine(("52" + "273").GetType());

        int number = 52273;
        string outputA = number + "";
        Console.WriteLine(outputA);

        char character = 'a';
        string outputB = character + "";
        Console.WriteLine(outputB);
    }
}