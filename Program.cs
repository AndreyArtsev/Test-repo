int n = 10;
int[] array = new int[n];
Random random = new Random();

for (int i = 0; i < n; i++)
{
    array[i] = random.Next(0, 100);
}
Console.WriteLine("Array is: ");

for (int i = 0; i < n; i++)
{
    Console.WriteLine(array[i] + "");
}
Console.WriteLine();

Console.WriteLine(array[3]);