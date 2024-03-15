/*
 * 작성일 : 2024년 3월 15일
 * 작성자 : 컴퓨터공학부 202395007 김수종
 * 설명 : 자료형
 */
internal class Program
{
    private static void Main(string[] args)
    {
        // 시간을 나타내는 DateTime
        Console.WriteLine("현재 Hour : " + DateTime.Now.Hour);

        // 연산자 비교 -> bool 자료형 출력
        Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour); // or -> 논리합
        Console.WriteLine(3 < DateTime.Now.Hour && DateTime.Now.Hour < 8); // and -> 논리곱

        // 오버플로우, 언더플로우 발생 시
        int a1 = -2147483648;
        int b1 = -1;
        Console.WriteLine(a1 + b1); // 언더플로우는 양수의 가장 큰 수로 이동

        int a2 = 2147483647;
        int b2 = 1;
        Console.WriteLine(a2 + b2); // 오버플로우는 음수의 가장 작은 수로 이동

        Console.WriteLine("int의 최대값 : " + int.MaxValue); // int의 정수 범위 -2^31 ~ 2^31-1
        Console.WriteLine("int의 최소값 : " + int.MinValue);

        Console.WriteLine("long의 최대값 : " + long.MaxValue);
        Console.WriteLine("long의 최소값 : " + long.MinValue);

        // 더 넓은 정수의 범위인 uint, ulong이 존재한다.

        // 자료형의 변환
        int x = 10, y = 6;
        Console.WriteLine(x + " + " + y + " = " + (x + y));
        Console.WriteLine(x + " - " + y + " = " + (x - y));
        Console.WriteLine(x + " * " + y + " = " + (x * y));
        Console.WriteLine(x + " / " + y + " = " + ((double)x / y));
        Console.WriteLine(x + " % " + y + " = " + (x % y));
        // 사용 용도가 다른 연산자를 사용했을 때 헷갈리면 괄호로 묶을 수 있음

        // ASCII 코드
        char charactor = 'A';
        int asciiCode = 65;
        Console.WriteLine(charactor); // A
        Console.WriteLine((char)asciiCode); // A

        // char의 사이즈는 c#과 Java에서는 2바이트임
        char Hangul = '뛟';
        Console.WriteLine(Hangul); // C는 출력 안됨(char = 1byte)

        // 문자형으로 연산 가능 (ASCII 코드로 계산)
        char a = 'a';
        char b = 'c';
        Console.WriteLine(a + " + " + b + " = " + (a + b));
        Console.WriteLine(a + " - " + b + " = " + (a - b));
        Console.WriteLine(a + " * " + b + " = " + (a * b));
        Console.WriteLine(a + " / " + b + " = " + ((double)a / b));
        Console.WriteLine(a + " % " + b + " = " + (a % b));

    }
}