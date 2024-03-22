internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("문자 입력 : ");
         int ascii = Console.Read(); // 한 문자를 입력 받아 정수 형태로 변수에 저장

        Console.WriteLine("\n1. 연산 수행 전");
        Console.WriteLine("- 아스키코드 값 : " + ascii);
        Console.WriteLine("- 변환된 문자 출력 : " + Convert.ToChar(ascii) + "\n");
        // Convert.Tochar()을 사용하여 해당 아스키코드 값에 해당하는 문자로 변환한 후 출력

        Console.WriteLine("2. 연산 수행 후");
        Console.WriteLine("- 아스키코드 값 : " + (ascii + 5));
        Console.WriteLine("- 변환된 문자 출력 : " + Convert.ToChar(ascii + 5));

    }
}