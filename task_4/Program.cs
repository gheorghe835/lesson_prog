
var a = 124;
var b = 88;
int c = 4;
int max = 0;

if (max < a)
{
    max = a;
    //Console.WriteLine($" The number :: {max} is maximum");
}
if (max < b)
{
    max = b;
    //Console.WriteLine($" The number :: {max} is maximum");
}
if(max < c)
{
    max = c;
    //Console.WriteLine($" The number :: {max} is maximum");
}

Console.WriteLine($" The number :: {max} is maximum");

Console.WriteLine("-----------------------");

Console.Write($" Enter the number N :: ");
int N = int.Parse(Console.ReadLine());
int i = 0;
Console.WriteLine($" \n The number N :: {N}");
while(i <= N)
{
    Console.WriteLine($" The number i :: {i}");
    i++;
}
//Console.WriteLine($" \n The number N :: {N}");
