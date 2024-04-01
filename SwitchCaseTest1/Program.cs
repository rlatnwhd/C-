internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("점수를 입력하세요 : ");
        int score = int.Parse(Console.ReadLine());

        switch (score / 10)
        {
            case 9:
                Console.WriteLine("A학점");
                break;
            case 8:
                Console.WriteLine("B학점");
                break;
            case 7:
                Console.WriteLine("C학점");
                break;
            case 6:
                Console.WriteLine("D학점");
                break;
            default:
                Console.WriteLine("재수강으로 분발하세요.");
                break;
        }
    }
}