
Console.WriteLine("Введите трехзначное число > ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введенное число {number} ");
int secondRank = number / 10 % 10;
Console.WriteLine($"Вторая цифра {secondRank} ");