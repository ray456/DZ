int[] array = GetArray(4, 100, 999);
PrintArray(array);
Console.WriteLine();
EvenNumbers(array);


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void PrintArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"{inArray[i]} ");
    }

}

void EvenNumbers(int[] array)
{
    int EvenNumbers = 0;
    

    foreach (int x in array)
    {
        if (x%2 == 0)
        {
            EvenNumbers++;
        }
        
        
    }
    Console.WriteLine($"Количество четных чисел = {EvenNumbers}");
}

