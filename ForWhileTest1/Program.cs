internal class Program
{
    private static void Main(string[] args)
    {
        int i = 0;
        int[] intArray = new int[5];
        while (i < intArray.Length)
        {
            Console.Write($"{i+1}번째 입력 : ");
            int num = int.Parse(Console.ReadLine());
            intArray[i] = num;
            i++;
        }
        Console.WriteLine();
        for (i=0; i < intArray.Length; i++)
        {
            Console.WriteLine($"{i+1}번째 출력 : {intArray[i]}");
        }
    }
}