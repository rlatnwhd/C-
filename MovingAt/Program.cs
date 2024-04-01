internal class Program
{
    private static void Main(string[] args)
    {
        int x = 1;
        while (x < 50)
        {
            Console.Clear();
            Console.SetCursorPosition(x, 5);

            // 출력합니다.
            switch (x % 3)
            {
                case 0:
                    Console.WriteLine("__@");
                    break;
                case 1:
                    Console.WriteLine("_^@");
                    break;
                default:
                    Console.WriteLine("^_@");
                    break;
            }
            Thread.Sleep(500);
            x++;
        }
    }
}