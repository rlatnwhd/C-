internal class Program
{
    private static void Main(string[] args)
    {
        Random r = new Random();
        List<int> list = new List<int>();
        Console.Write("입력 받을 랜덤 수의 개수를 입력하세요. :  ");
        int num = int.Parse(Console.ReadLine());
        for (int i = 0; i < num; i++)
        {
            list.Add(r.Next(1, 100));
        }

        // 리스트 원소 개수와 랜덤 수 출력 (list.Count 이용)
        Console.WriteLine("Count : " + list.Count);
        Console.Write("list : ");
        foreach (var item in list)
        {
            Console.Write("{0, 3}", item);
        }

        // 특정 위치의 항목 제거 (list.RemoveAt 이용)
        Console.WriteLine("\n\n------- 항목 삭제 후 1 -------");
        Console.WriteLine("list.RemoveAt(0) -> 0번지 인덱스 항목 삭제");
        list.RemoveAt(0);
        Console.WriteLine("Count : " + list.Count);
        Console.Write("list : ");
        foreach (var item in list)
        {
            Console.Write("{0, 3}", item);
        }

        // 마지막만 뺴고 다 지운 후 출력 (list.RemoveRange 이용)
        Console.WriteLine("\n\n------- 항목 삭제 후 2 -------");
        Console.WriteLine("list.RemoveRange(0, list.Count - 1) -> 0번지부터 마지막 전까지의 항목 삭제");
        list.RemoveRange(0, list.Count - 1);
        Console.WriteLine("Count : " + list.Count);
        Console.Write("list : ");
        foreach (var item in list)
        {
            Console.Write("{0, 3}", item);
        }
    }
}