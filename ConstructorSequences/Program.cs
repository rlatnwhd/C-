class Parent
{
    public Parent() { Console.WriteLine("Parent()"); }
    public Parent(int param) { Console.WriteLine("Parent(int param)"); }
    public Parent(string param) { Console.WriteLine("Parent(string param)"); }
}
class Child : Parent
{
    public Child() : base()
    {
        Console.WriteLine("Child() : base()\n");
    }
    public Child(int num) : base(num)
    {
        Console.WriteLine("Child() : base(num)\n");
    }
    public Child(string input) : base(input)
    {
        Console.WriteLine("Child(string input) : base(input)\n");
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Child childA = new Child();
        Child childB = new Child(10);
        Child childC = new Child("string");
    }
}