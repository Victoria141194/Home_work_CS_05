int[] array = FillArray(10, 100, 999);
PrintArray(array);
int count = GetEvenNumbers(array);
Console.WriteLine(" ");
Console.Write($"Количество четных чисел: {count}");

///////////////////////////
int[] FillArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}


int GetEvenNumbers(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el % 2 == 0) count++;
    }
    return count;
}
