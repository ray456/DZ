﻿Console.WriteLine("Введите число > ");
int number = Convert.ToInt32(Console.ReadLine());

{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number = number / 10;
    }
    Console.WriteLine($"Сумма всех чисел в цифре  = {sum}");
}

