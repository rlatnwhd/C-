class Cup<T>
{
    public T Content { get; set; }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

}

internal class Program
{
    private static void Main(string[] args)
    {
        Person person = new Person { Name = "김수종", Age = 20 };

        Cup<Person> pc = new Cup<Person> { Content = person };

        Console.WriteLine(pc.Content.Name + " - " + pc.Content.Age);
    }
}