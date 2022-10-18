int size = GetNumberFromUser("Введите количество элементов массива: ", "Ошибка ввода!");
int[] array = FillArray(size, 1, 100);
PrintArray(array);
int sum = OddSum(array);
Console.Write($"Сумма элементов на нечетных позициях: {sum}");


/////////////////////////////////////////////////////
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}


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


int OddSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 1)
        {
            sum += array[i];
        }
        
    }
    return sum;
}