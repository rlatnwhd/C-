internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("입력할 숫자의 개수 : ");
        int range = int.Parse(Console.ReadLine());
        int i = 1, sum = 0;
        while (i <= range)
        {
            Console.Write($"{i} 번째 : ");
            int num = int.Parse(Console.ReadLine());
            if(num > 10 || num < 0)
            {
                Console.WriteLine("유효한 수가 아님! 다시 입력");
                continue;
            }
            sum += num;
            i++;
        }
        Console.WriteLine($"\n합계 : {sum}, 평균 : {(double)sum / range :F2}");
    }
}