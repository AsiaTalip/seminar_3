using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите пятизначное число: ");
        int number = int.Parse(Console.ReadLine());

        int fifthDigit = number % 10;
        int fourthDigit = (number / 10) % 10;
        int thirdDigit = (number / 100) % 10;
        int secondDigit = (number / 1000) % 10;
        int firstDigit = (number / 10000) % 10;

        if (firstDigit == fifthDigit && secondDigit == fourthDigit)
        {
            Console.WriteLine("Число является палиндромом.");
        }
        else
        {
            Console.WriteLine("Число не является палиндромом.");
        }

        Console.ReadKey();
    }
}
