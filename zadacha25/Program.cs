
double a;
double b;
double c;
Console.WriteLine("Введите число, которое хотите возвести в степень ");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите степень числа ");
b = Convert.ToDouble(Console.ReadLine());
c = Math.Pow(a, b);
Console.WriteLine("Число в степени = " + c);
