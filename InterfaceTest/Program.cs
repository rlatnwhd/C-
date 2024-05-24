namespace InterfaseTest
{
    internal class Program
    {
        interface IUpgradable
        {
            void Upgrade();
        }
        interface ISellable
        {
            void Sell();
        }
        class Monster : IUpgradable, ISellable
        {
            public int Level { get; set; }
            public int Price { get; set; }

            public void Sell()
            {
                Console.WriteLine("Sell Monster : $" + Price);
            }

            public void Upgrade()
            {
                Price += 1000;
                Console.WriteLine("Upgrade Monster : Level " + ++Level);
            }
        }

        class Item : ISellable
        {
            public int Price { get; set; }

            public void Sell()
            {
                Console.WriteLine("Sell Item : $" + Price);
            }
        }
        private static void Main(string[] args)
        {
            Monster monster = new Monster();
            monster.Level = 3;
            monster.Price = 2000;

            monster.Upgrade();
            monster.Sell();

            Item item = new Item();
            item.Price = 500;
            item.Sell();
        }
    }
}
