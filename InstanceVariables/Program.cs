internal class Program
{
    class Product
    {
        public string name;
        public int price;
        public void Print()
        {
            Console.WriteLine($"name : {name}\nprice : {price}");
        }
    }
    private static void Main(string[] args)
    {
        Product productA = new Product() { name = "감자", price = 2000 };
        Product productB = new Product() { name = "고구마", price = 3000 };
        productA.Print();
        productB.Print();
    }
}