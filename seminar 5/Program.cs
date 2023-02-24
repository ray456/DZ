// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] array = GetArray(12, -9, 9);
PrintArray(array);
Console.WriteLine();
FindSum(array);


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

void FindSum(int[] array)
{
    int positiveSum = 0;
    int negativeSum = 0;

    foreach (int el in array)
    {
        if (el > 0)
        {
            positiveSum += el;
        }
        else
        {
            negativeSum += el;
        }
    }
    Console.WriteLine($"Сумма положительных чисел = {positiveSum}, сумма отрицательных чисел = {negativeSum}");
}

// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];//создание массива
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

void ReplaceIndex(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        inArray[i] = inArray[i] * -1;
    }
}

int[] array = GetArray(12, -9, 9);
PrintArray(array);
System.Console.WriteLine();
ReplaceIndex(array);
System.Console.WriteLine();
PrintArray(array);
// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
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

void FindIndex(int[] inArray, int index)
{
    bool flag = false;
    for (int i = 0; i < inArray.Length; i++)
    {
        
        if (inArray[i] == index)
        {
            flag = true;
        }
    }
    if (flag)
    {
        System.Console.WriteLine("Да");
    }
    else
    {
        System.Console.WriteLine("Нет");
    }
}

int[] array = GetArray(12, -9, 9);
PrintArray(array);
System.Console.WriteLine();
System.Console.Write("Введите число: ");
int num = int.Parse(System.Console.ReadLine());
FindIndex(array, num);
// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
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

void FindSumIndex(int[] inArray)
{
    int summindex = 0;
    for (int i = 0; i < inArray.Length; i++)
    {

        if (inArray[i] >= 10 && inArray[i] <= 99)
        {
            summindex++;
        }
    }
    System.Console.WriteLine($"Сумма элементов = " + summindex);
}

System.Console.WriteLine("Введите минимальное и максимальное значение массива: ");
int minindex = int.Parse(Console.ReadLine());
int maxindex = int.Parse(Console.ReadLine());
int[] array = GetArray(10, minindex, maxindex);
PrintArray(array);
System.Console.WriteLine();
FindSumIndex(array);
// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
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

int[] GetComposition(int[] inArray)
{
   
    int[] result = new int [inArray.Length / 2];
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        result[i] = inArray[i] * inArray[inArray.Length - 1-i];   
    }
    return result;
}

int[] array = GetArray(6, 1, 10);
PrintArray(array);
System.Console.WriteLine();
int[] resultArr = GetComposition(array);
PrintArray(resultArr);