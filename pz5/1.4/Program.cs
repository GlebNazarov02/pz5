int[] Mass(int size)
{
    int[] arr = new int[size];
    for (int i =0;i < size;i++)
    {
        arr[i] = new Random().Next(1,10);
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

void Newmass(int[] arr)
{   
    int l2 = 0;
    int l = arr.Length;
    if (l % 2 == 0)
    {
        l2 = l/2;
    }
    else
    {
        l2 = l/2 + 1;
    }
    int[] mass2 = new int[l2];
    for (int i = 0;i < l;i++)
    {
        if (i != (l-1))
        {
            mass2[i] = arr[i] * arr[l-1];
            Console.Write($"{mass2[i]} ");
            l = l -1;
        }
        else
        {
            mass2[i] = arr[i];
            Console.Write($"{mass2[i]} ");
        }
    }
}
Console.WriteLine("Kol vo");
int razm = int.Parse(Console.ReadLine());
int[] massiv = Mass(razm);
Prin(massiv);
Newmass(massiv);