internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("처음 문자 입력 : ");
        char start = char.Parse(Console.ReadLine());
        Console.Write("마지막 문자 입력 : ");
        char end = char.Parse(Console.ReadLine());

        for (int i = start; i <= end; i++)
        {
            Console.Write($"{(char)i, 3}");
        }
    }
}