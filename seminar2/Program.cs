﻿int i = 1;
while (i <= 36)
{
    if (i % 3 == 0 && i % 6 == 0)
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
