internal class Program
{
    class Category
    {
        public int Categoryld { get; set; }
        public string CategoryName { get; set; }
    }
    private static void Main(string[] args)
    {
        List<Category> category = new List<Category>()
        {
            new Category() { Categoryld = 1, CategoryName = "좋은 책"},
            new Category() { Categoryld = 2, CategoryName = "좋은 강의"},
            new Category() { Categoryld = 3, CategoryName = "컴퓨터"}
        };

        foreach (var item in category)
        {
            Console.WriteLine(item.Categoryld + " - " + item.CategoryName);
        }
    }
}