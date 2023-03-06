
Console.WriteLine("Введите трехзначное число > ");
int number = Convert.ToInt32(Console.ReadLine());

int secondRank = number / 10 % 10;

Console.WriteLine($"Вторая цифра {secondRank} ");