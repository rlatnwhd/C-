﻿
internal class Program
{
    class Student
    {
        public string name;
        public int grade;
    }
    private static void Main(string[] args)
    {
        List<Student> list = new List<Student>();
        list.Add(new Student() { name = "윤인성", grade = 1 });
        list.Add(new Student() { name = "연하진", grade = 2 });
        list.Add(new Student() { name = "윤아린", grade = 3 });
        list.Add(new Student() { name = "윤명월", grade = 4 });
        list.Add(new Student() { name = "구지연", grade = 1 });
        list.Add(new Student() { name = "김연화", grade = 2 });
        Searchgrade(list);
    }

    private static void Searchgrade(List<Student> gradelist)
    {
        List<Student> grade2 = new List<Student>();
        for (int i = gradelist.Count-1; i >= 0; i--)
        {
            if (gradelist[i].grade == 1)
            {
                grade2.Add(new Student() { name = gradelist[i].name, grade = gradelist[i].grade });
            }
        }
        ShowList(grade2);
    }

    private static void ShowList(List<Student> otherlist)
    {
        foreach (var item in otherlist)
        {
            Console.WriteLine(item.name + " : " + item.grade);
        }
    }
}