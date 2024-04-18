using System.Diagnostics.Metrics;

internal class Program
{
    class Product
    {
        private static int counter = 0;
        private int id;
        private string name;
        private int price;

        public Product(string name, int price)
        {
            Product.counter = ++counter;
            this.id = counter;
            this.name = name;
            this.price = price;
        }

        public int getId() { return id; }
        public string getName() { return name; }
        public int getPrice() { return price; }
    }
        

    private static void Main(string[] args)
    {
        Product productA = new Product("감자", 2000);
        Product productB = new Product("고구마", 3000);

        Console.WriteLine(productA.getId() + ":" + productA.getName() + " " + productA.getPrice());
        Console.WriteLine(productB.getId() + ":" + productB.getName() + " " + productB.getPrice());
        Console.WriteLine(productB.getId() + "개 생성되었습니다.");
    }
}