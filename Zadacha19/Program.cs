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
            Console.WriteLine("Число палиндромное.");
        else
            Console.WriteLine("Число не палиндромное.");
