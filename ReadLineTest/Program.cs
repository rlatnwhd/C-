internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("첫 번째 정수를 입력하세요 : ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("두 번째 정수를 입력하세요 : ");
        int num2 = int.Parse(Console.ReadLine());


        Console.WriteLine(num1 + " + " + num2 + " = " + (num1+num2));
        Console.WriteLine(num1 + " - " + num2 + " = " + (num1-num2));
        Console.WriteLine(num1 + " * " + num2 + " = " + (num1*num2));
        Console.WriteLine(num1 + " / " + num2 + " = " + ((float)num1/num2).ToString("F2"));
        Console.WriteLine(num1 + " % " + num2 + " = " + (num1%num2));

    }
}