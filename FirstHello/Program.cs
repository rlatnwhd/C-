/*
 * 작성일 : 2024년 3월 14일
 * 작성자 : 컴퓨터공학부 202395007 김수종
 * 설명 : C#의 기본 개념
*/
internal class Program
{
    private static void Main(string[] args)
    {
        // Write은 줄바꿈을 포함하지 않은 출력
        Console.Write("Hello, World!\n");

        // WriteLIne은 줄바꿈을 포함한 출력 (\n 도 가능)
        Console.WriteLine("Hello, World!");

        // format 없이 연산 바로 출력 가능(연산자 우선 순위로 계산)
        Console.WriteLine(5 + 3 + 3);

        // 정수 계산은 값이 정수로, 실수 계산은 값이 실수로 나온다.
        Console.WriteLine(5 + 4);
        Console.WriteLine(5.0 + 3.0);

        // 나머지 연산은 실수로 계산이 불가능하다.
        // Console.WriteLine(5.0 % 3.0);

        // 나머지 계산은 값이 왼쪽 연산자의 부호에 따라 값이 결정된다.
        Console.WriteLine(-5 % 3); // 나머지 -2
        Console.WriteLine(5 % -3); // 나머지 2

        // 작은따옴표(')는 하나의 문자를 적을 때 사용
        Console.WriteLine('A');

        // 큰따옴표(")는 문자열을 적을 때 사용
        Console.WriteLine("문자열 출력");

        // \t = 수평 탭, \n = 줄바꿈, \\ = 역슬래시 출력, \" = 큰따옴표 출력(작은따옴표 동일)
        Console.WriteLine("\t탭");
        Console.WriteLine("\", \'");

        // C#에서만 가능한 문자열 인덱스
        Console.WriteLine("안녕하세요"[0]); // 안
        Console.WriteLine("안녕하세요"[1]); // 녕
        Console.WriteLine("안녕하세요"[2]); // 하
        // Console.WriteLine("안녕하세요"[1000]); 런타임 오류(인덱스 범위 오버)

        // 문자열 연결은 + 연산자를 사용하지만 문자는 연결이 불가능
        Console.WriteLine("가나다라" + "마바사");
        // Console.WriteLine('가' + '나'); 문자열 연결 불가능
    }
}