internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("정수 3개 입력");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        int middle;
        if(num1 > num2)
        {
            if(num3 > num1)
            {
                middle = num1;
            }
            else
            {
                middle = num3;
            }
            if(middle < num2)
            {
                middle = num2;
            }
        }
        else
        {
            if(num3 > num2)
            {
                middle = num2;
            }
            else
            {
                middle = num3;
            }
            if (middle < num1)
            {
                middle = num1;
            }
        }
        Console.WriteLine("중간 값은  : " + middle);
    }
}