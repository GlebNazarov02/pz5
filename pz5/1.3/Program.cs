int[] Mass(int size)
{
    int[] arr = new int[size];
    for (int i =0;i < size;i++)
    {
        arr[i] = new Random().Next(0,124);
    }
    return(arr);
}

void Prin(int[] arr)
{
    int l = arr.Length;
    for(int i = 0;i < l;i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void Kolvo(int[] arr)
{
    int s = 0;
    int l = arr.Length;
    for (int i = 0; i < l;i++)
    {
        if ((arr[i] >= 10) && (arr[i] <= 99))
        {
            s += 1;
        }
    }
    Console.WriteLine($"{s}");
}

int[] massiv = Mass(123);
Prin(massiv);
Kolvo(massiv);