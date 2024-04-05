internal class Program
{
    private static void Main(string[] args)
    {
        Random r = new Random();
        Console.Write("생성할 랜덤 수의 개수를 입력하세요. : ");
        int range = int.Parse(Console.ReadLine());
        int[] intArray = new int[range];
        for (int i = 0;  i < intArray.Length; i++)
        {
            intArray[i] = r.Next(1, 46);
            for (int j = 0; j < i; j++)
            {
                if (intArray[j] == intArray[i])
                {
                    i--;
                    break;
                }
            }
        }
        Console.WriteLine($"생성된 {intArray.Length}개의 랜덤한 숫자 출력");
        foreach(int value in intArray)
        {
            Console.Write("{0,3}", value);
        }
    }
}