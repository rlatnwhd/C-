internal class Program
{
    private static void Main(string[] args)
    {
        // 변수 선언
        Console.Write("이번 달은 몇 월인가요? : ");
        int month = int.Parse(Console.ReadLine());

        // 조건문
        if (month == 1 || month == 2 || month == 12)
        {
            Console.WriteLine("겨울입니다.");
        }
        else if (month == 3 || month == 4 || month == 5)
        {
            Console.WriteLine("봄입니다.");
        }
        else if (month == 6 || month == 7 || month == 8)
        {
            Console.WriteLine("여름입니다.");
        }
        else if (month == 9 || month == 10 || month == 11)
        {
            Console.WriteLine("가을입니다.");
        }
        else
        {
            Console.WriteLine("대체 어떤 생성에 살고 계신가요?");
        }
    }
}