int size = GetNumberFromUser("Введите количество элементов массива: ", "Ошибка ввода!");
double[] array = FillArray(size);
PrintArray(array);
double min = GetMinValue(array);
double max = GetMaxValue(array);
double diff = max - min;
Console.Write($"Разница между элементами: {diff}");


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


double[] FillArray(int size)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * 10, 2);
    }
    return array;
}


void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}


double GetMinValue(double[] array)
{
    double min = array[0];
    foreach (double element in array)
    {
        if (element < min) min = element;
    }
    return min;
}


double GetMaxValue(double[] array)
{
    double max = array[0];
    foreach (double element in array)
    {
        if (element > max) max = element;
    }
    return max;
}
