class Sum
{
    public int Get(int num)
    {
        if (num == 0) return 0;
        return (Get(num - 1) + num);
    }
}
internal class Program
{
    
    private static void Main(string[] args)
    {
        Sum sum = new Sum();
        Console.Write("1부터 합계를 출력할 수 입력 : ");
        int num = sum.Get(int.Parse(Console.ReadLine()));
        Console.WriteLine(num);
    }
}