// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// // причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
Console.Write("введите X: ");
int X = int.Parse(Console.ReadLine());

Console.Write("введите Y: ");
int X = int.Parse(Console.ReadLine());

if (x > 0 $$ Y > 0)






















// задача 2
System.Console.Write("Введите x1:");
int x1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите x2:");
int x2 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите y1:");
int y1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите y2:");
int y2 = Convert.ToInt32(Console.ReadLine());

double S = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

System.Console.WriteLine(Math.Round(S,2));

// задача 3
System.Console.Write("Введите номер четверти: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a>0 && a<5)
{
    if (a ==1)
    {
        System.Console.WriteLine("x>0 и y>0");
    }
    if (a ==2)
    {
        System.Console.WriteLine("x<0 и y>0");
    }
    if (a ==3)
    {
        System.Console.WriteLine("x<0 и y<0");
    }
    if (a ==4)
    {
        System.Console.WriteLine("x>0 и y<0");
    }
}
else
{
    System.Console.WriteLine("Такой четверти не бывает");
}

// задача 4
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
// int i = 1;

// while (i <= N)
// {
//     Console.Write(Math.Pow(i,2) + " ");
//     i++;
// }
for (int i = 1; i <= N; i++)
{
    Console.Write(Math.Pow(i, 2) + " ");
}
// Домашнее задание
// Задача 19: Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
Console.WriteLine("Введите пятизначное число:");
        int number = Convert.ToInt32(Console.ReadLine());
        int reversedNumber = 0;
        int temp = number;
        while (temp > 0)
        {
            reversedNumber = reversedNumber * 10 + temp % 10;
            temp /= 10;
        }
        if (number == reversedNumber)
            Console.WriteLine("Число палимдромное.");
        else
            Console.WriteLine("Число не палимдромное.");