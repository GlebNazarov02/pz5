void Mass(int n)
{
    int[] array = new int[n];
    for (int i = 0;i<n;i++)
    {
        array[i] = new Random().Next(-9, 10);
        Console.Write($"{array[i]} ");
    }
    int sum1 = 0;
    int sum2 = 0;
    for (int i = 0;i<n;i++)
    {
        if (array[i] >= 0)
        {
            sum1 = sum1 + array[i];
        } 
        else
        {
            sum2 = sum2 +array[i];
        }
    }

    Console.WriteLine($"Суума полож = {sum1}");
    Console.WriteLine($"Суума отр = {sum2}");
}
int s = 12;
Mass(s);