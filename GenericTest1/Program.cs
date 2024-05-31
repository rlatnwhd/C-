internal class Program
{
    static void CopyArray<T>(T[] source, T[] target)
    {
        for (int push = 0; push < target.Length; push++) { source[push] = target[push]; }
    }
    private static void Main(string[] args)
    {
        int[] source = new int[10];
        int[] target = new int[10];
        for (int i = 0; i < target.Length; i++) { target[i] = i + 1; }
        CopyArray<int>(source, target);

        foreach (int score in source) { Console.WriteLine(score); }
    }
}