int Square(int value)
{
    int result = value * value;
    return result;
}
int a = 8;
int value = Square(a);

Console.WriteLine($"  The number {value} :: is square of number {a}");
Console.WriteLine($"-----------------------------------------------");

Console.Write($" Enter the number N :: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($" \n The number N :: {N}");

void Function(int N)
{
    int i = 0;
    while (i < N)
    {
        Console.WriteLine($" \n The number i :: {i}");
        i++;
    }
}

Function(N);

Console.WriteLine($"-----------------------------------------------");

void ZeroEvenElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 888;
        }
    }
}
void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.WriteLine($" Array :: {e}");
    }
}
int[] array = { 1, 3, 5, 6, 7, 8, 80 };
ZeroEvenElements(array);
PrintArray(array);