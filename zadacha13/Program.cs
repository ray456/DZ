Console.WriteLine("Введите число > ");
int number = Convert.ToInt32(Console.ReadLine());
int x = 0;

{
    if (number >= 100)
    {
        while (number > 999)
        number = number / 10; 
        x = number % 10;
    }
    
Console.WriteLine("третья цифра " + x);
}  
{  
     if (number < 100)
    Console.WriteLine("число не трехзначное ");
}