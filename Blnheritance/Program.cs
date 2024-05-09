class Animal
{
    public int Age { get; set; }
    public Animal() { Age = 0; }

    public void Eat() { Console.WriteLine("냠냠"); }
    public void Sleep() { Console.WriteLine("쿨쿨"); }
}

class Dog : Animal
{
    public string Color { get; set; }

    public void Bark() { Console.WriteLine("멍멍"); }
}

class Cat : Animal
{
    public void Meow() { Console.WriteLine("냥냥"); }
}

internal class Program
{
    private static void Main(string[] args)
    {
        // List<Dog> dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
        // List<Cat> cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };
        List<Animal> animals = new List<Animal>()
        {
            new Dog(), new Dog(),
            new Cat(), new Cat()
        };

        foreach (var item in animals)
        {
            item.Eat();
            item.Sleep();

            if (item is Dog) { ((Dog)item).Bark(); }
            if (item is Cat) { ((Cat)item).Meow(); }
        }

        // foreach (var item in dogs)
        // {
        //     item.Eat();
        //     item.Sleep();
        //     item.Bark();
        // }
         
        // foreach (var item in cats)
        // {
        //     item.Eat();
        //     item.Sleep();
        //     item.Meow();
        // }
    }
}