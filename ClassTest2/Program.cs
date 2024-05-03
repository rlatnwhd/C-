
class TV
{
    public string com;
    public int year;
    public int inch;

    public TV(string com, int year, int inch)
    {
        this.com = com;
        this.year = year;
        this.inch = inch;
    }
    public void show()
    {
        Console.Write(com + "에서 만든 " + year + "년형 " + inch + "인치 TV");
    }
}
class Grade
{
    private int math;
    private int english;
    private int science;
    public Grade(int math, int english, int science)
    {
        this.math = math;
        this.english = english;
        this.science = science;
    }

    public double average()
    {
        return (math+english+science)/3.0;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        TV myTV = new TV("LG", 2017, 32);
        myTV.show();
        Console.Write("\n수학 점수 입력 : ");
        int math = int.Parse(Console.ReadLine());
        Console.Write("과학 점수 입력 : ");
        int science = int.Parse(Console.ReadLine());
        Console.Write("영어 점수 입력 : ");
        int english = int.Parse(Console.ReadLine());
        Grade score = new Grade(math, science, english);

        Console.WriteLine("세 점수의 평균 : " + score.average().ToString("0.00"));
    }
}


