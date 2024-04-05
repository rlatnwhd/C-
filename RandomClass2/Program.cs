internal class Program
{
    private static void Main(string[] args)
    {
        Random r = new Random();
        Console.Write("랜덤하게 생성할 수의 개수 : ");
        int range = int.Parse(Console.ReadLine());
        int[] intArray = new int[range];
        for (int i = 0; i < intArray.Length; i++)
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
        Console.Write($"랜덤값 출력 :");
        foreach (int value in intArray)
        {
            Console.Write("{0,3}", value);
        }
        int min = intArray[0], max = intArray[0];
        for (int i = 0; i < intArray.Length; i++)
        {
            if (min > intArray[i]) min = intArray[i];
            if (max < intArray[i]) max = intArray[i];
        }
        Console.WriteLine("\n\n최대값 : " + max);
        Console.WriteLine("최소값 : " + min);
    }
}