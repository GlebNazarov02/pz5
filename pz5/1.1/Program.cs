void Mass(int n)
{
    int[] a = new int[n];
    for (int i = 0;i<n;i++)
    {
        a[i] = int.Parse(Console.ReadLine());
    }
    for (int i = 0;i<n;i++)
    {
        a[i] = - a[i];
    }
    Console.Write("[");
    for (int i = 0;i<(n-1);i++)
    {
        Console.Write($"{a[i]},");
    }
    Console.Write($"{a[n-1]}");
    Console.Write("]");
}
Console.WriteLine("Кол-во");
int s = int.Parse(Console.ReadLine());
Mass(s);