internal class Program
{
    private static void Main(string[] args)
    {
        using (StreamWriter sw = new StreamWriter(@"c:\test\test.txt"))
        {
            sw.WriteLine("안녕하세요");
            sw.WriteLine("StreamWriter 클래스를 사용해");
            sw.WriteLine("글자를 여러 줄 입력해봅시다.");

            for (int i = 0; i < 10; i++)
            {
                sw.WriteLine("반복문 - " + i);
            }

        }

        using (StreamReader sr = new StreamReader(@"c:\test\test.txt"))
        {
            string line;
            while (true)
            {
                line = sr.ReadLine();
                if (Equals(line, "반복문 - 0"))
                {
                    for (int i = 0; i < 5; i++)
                    {
                        line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                    break;
                }
            }
        }
            
        
    }
}