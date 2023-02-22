
void FillArray(int[] array)
{
    int length = array.Length;

    for (int index = 0; index < length; index++)
    {
        array[index] = new Random().Next(0, length);
        Console.Write(array[index] + " ");
    }
}

void PrintArray(int[] mas)
{
    int len = mas.Length;
    for (int i = 0; i < len; i++)
    {        
        Console.Write(mas[i] + " ");
    }
}

int[] arr = new int[8];
FillArray(arr);
Console.WriteLine();
PrintArray(arr);