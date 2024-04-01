internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("첫 번째 정수를 입력하세요. : ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("두 번째 정수를 입력하세요. : ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("연산자를 입력하세요.(+, -, *, /, %) : ");
        char oper = char.Parse(Console.ReadLine());

        switch (oper)
        {
            case '+':
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                break;
            case '-':
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                break;
            case '*':
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                break;
            case '/':
                Console.WriteLine($"{num1} / {num2} = {(double)num1 / num2 :F3}");
                break;
            case '%':
                Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                break;
        }
        // Console.WriteLine($"{} + {} = {}") 포맷 형식
    }
}