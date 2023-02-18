int num = new Random().Next(100,999);
//int num = 918; 
System.Console.WriteLine(num);

int a1 = num / 100;
int a2 = num % 10;

System.Console.WriteLine(a1 * 10 + a2);

System.Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 % num2 == 0)
{
    System.Console.WriteLine("Первое число кратно второму");
}
else
{
    System.Console.WriteLine("Первое число некратно второму. Остаток: " + (num1 % num2));
}
// Задача 3
System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(num);

if (num % 7 == 0 && num % 23 == 0)
{
    System.Console.WriteLine("Число кратно 7 и 23.");
}
else
{
    System.Console.WriteLine("Число некратно");
}
// Задача 4
System.Console.Write("Введите 1-ое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите 2-ое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int min = num1;
int max = num1;

if (num1 > num2)
{
    min = num2;
}
else
{
    max = num2;
}

int minSqr = min * min;

if (minSqr== max) 
{
    System.Console.WriteLine("Одно число является квадратом другого");
}
else
{
    System.Console.WriteLine("Не является квадратом");
}
// Задача 5
int i = 1;
while (i <= 17)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        System.Console.WriteLine("FizzBuzz");
    }     
    else if(i % 3 == 0)
    {
        System.Console.WriteLine("Fizz");
    }
    else if(i % 5 == 0)
    {
        System.Console.WriteLine("Buzz");
    }
    
    else
    {
        System.Console.WriteLine(i);
    }

    i++;

}