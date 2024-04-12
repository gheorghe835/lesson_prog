
Console.Write($" Enter the number N :: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($" \n  The number N :: {N}");
int[] array1 = new int[N];
int i = 0;
int max = array1[0];
while( i < N)
{
    array1[i] = i ;
    Console.WriteLine($"  The number i :: {array1[i]}");
    if(array1[i] > max)
    {
        max = array1[i];
    }
    i ++;
}
Console.WriteLine($"  The number maximum :: {max}");
Console.WriteLine($"-----------------------------");
for ( i = 0; i < N; i++)
{
    array1[i] = i ;
}
for ( i = 0; i < N; i++)
{
    Console.WriteLine($"  The number i :: {array1[i]}");
}
Console.WriteLine($"-----------------------------");
foreach (var item in array1)
{
    Console.WriteLine($"   {item} ");
}
