// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int GetSumNums(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number;
        number--;
    }
    return sum;
}

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма цифр = {GetSumNums(num)}");
Console.WriteLine($"Сумма цифр = {GetSumNums(num2)}");
Console.WriteLine($"Сумма цифр = {GetSumNums(num3)}");


// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
// int FindLen(int a)
// {
//     int count = 0;
//     int temp = a;
//     while (temp > 0)
//     {
//         temp = temp / 10;
//         count++;
//     }
//     return count;

// }

// System.Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Ответ: {FindLen(a)}");
// // Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// // 4 -> 24 
// // 5 -> 120
// int Mult(int A)
// {
//     int result = 1;
//     for (int i = 1; i <= A; i++)
//     {
//         result = result * i;
//     }
//     return result;

// }
// Console.Write("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Сумма чисел равна:  {Mult(A)}");

// // Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// // [1,0,1,1,0,1,0,0]
// void FillArray(int[] array)
// {
//     int length = array.Length;

//     for (int index = 0; index < length; index++)
//     {
//         array[index] = new Random().Next(0, 2);
//     }
// }

// void PrintArray(int[] mas)
// {
//     int len = mas.Length;
//     for (int i = 0; i < len; i++)
//     {
//         Console.Write(mas[i] + " ");
//     }
// }

// int[] arr = new int[8];
// FillArray(arr);
// PrintArray(arr);

// void FillArray(int[] array)
// {
//     int length = array.Length;

//     for (int index = 0; index < length; index++)
//     {
//         array[index] = new Random().Next(0, 2);
//         Console.Write(array[index] + " ");
//     }
// }

// void PrintArray(int[] mas)
// {
//     int len = mas.Length;
//     for (int i = 0; i < len; i++)
//     {        
//         Console.Write(mas[i] + " ");
//     }
// }

// int[] arr = new int[8];
// FillArray(arr);
// Console.WriteLine();
// PrintArray(arr);