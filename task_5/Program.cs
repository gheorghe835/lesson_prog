
int[] array = new int[7];
array[0] = 21;
array[1] = 22;
array[2] = 23;
array[3] = 24;
array[4] = 25;
array[5] = 26;
array[6] = 27;

Console.WriteLine(array[0]);
Console.WriteLine(array[1]);
Console.WriteLine(array[2]);
Console.WriteLine(array[3]);
Console.WriteLine(array[4]);
Console.WriteLine(array[5]);
Console.WriteLine(array[6]);
Console.WriteLine(" ---------------- ");

Console.Write($" Enter the number N :: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($" \n The number N :: {N}");
int[] array1 = new int[N];
int i = 0;
while( i <= N)
{
    array1[i] = i ;
    Console.WriteLine($" \n The number i :: {array1[i]}");
    i ++;
}


