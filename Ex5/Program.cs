int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int index = 0;
while (index < array.Length)
{
    if (array[index] % 2 == 0) 
    {
        Console.WriteLine(array[index]);
    }
    index++;
}