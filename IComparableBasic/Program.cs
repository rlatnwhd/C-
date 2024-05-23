using System.Diagnostics;
using System.Xml.Linq;

namespace IComparableBasic
{
    internal class Program
    {
        class Product : IComparable
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public int CompareTo(object obj)
            {
                return Name.CompareTo((obj as Product).Name);
            }

            public override string ToString()
            {
                return Name + " : " + Price + "원";
            }
        }

        class Student : IComparable
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public int CompareTo(object obj)
            {
                if (obj is Student otherStudent)
                {
                    return Age.CompareTo(otherStudent.Age);
                }
                throw new ArgumentException("Object is not Stduent");
            }
        }
        private static void Main(string[] args)
        {
            List<Product> list = new List<Product>()
            {
                new Product { Name = "고구마", Price = 1500 },
                new Product { Name = "사과", Price = 2400 },
                new Product { Name = "바나나", Price = 1000 },
                new Product { Name = "배", Price = 3000 },
            };

            List<Student> student = new List<Student>()
            {
                new Student { Name = "Alice", Age = 25 },
                new Student { Name = "Charlie", Age = 28 },
                new Student { Name = "Bob", Age = 22 },
            };

            list.Sort();
            student.Sort();

            foreach (var item in list) { Console.WriteLine(item); }
            foreach (var item in student) { Console.WriteLine(item.Name + " : " + item.Age + "살"); }
        }
    }
}