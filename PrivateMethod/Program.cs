using System.Security.Cryptography.X509Certificates;

internal class Test
{
    private string name();
    public void setName(string name)
    {
        this.name = name;
        Console.WriteLine(name);
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Test test = new Test();
        test.setName("홍길동");
    }
}

