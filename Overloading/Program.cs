internal class Program
{
    class MyMath
    {
        public int Abs(int input) // int형 매개변수의 절댓값
        {
            if (input < 0) return -input;
            return input;
        }
        public double Abs(double input) // double형 매개변수의 절댓값
        {
            if (input < 0) return -input;
            return input;
        }
        public long Abs(long input) // long형 매개변수의 절댓값
        {
            if (input < 0) return -input;
            return input;
        }
    }
    private static void Main(string[] args)
    {
        // 메서드 생성
        MyMath math = new MyMath();

        // int
        Console.WriteLine(math.Abs(52));
        Console.WriteLine(math.Abs(-273));

        // double
        Console.WriteLine(math.Abs(52.273));
        Console.WriteLine(math.Abs(-32.103));

        // long
        Console.WriteLine(math.Abs(21474836470));
        Console.WriteLine(math.Abs(-21474836470));
    }
}