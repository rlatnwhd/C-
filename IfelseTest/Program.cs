internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("나이 입력 : ");
        int age = int.Parse(Console.ReadLine());
        if (age >= 9)
        {
            Console.Write("키 입력 : ");
            int height = int.Parse(Console.ReadLine());
            if (height >= 130)
            {
                Console.WriteLine("고속 롤러코스터 입장 가능");
            }
            else
            {
                Console.WriteLine("저속 롤러코스터 입장 가능");
            }
        }
        else
        {
            Console.WriteLine("입장 불가!");
        }
        

        

    }
}