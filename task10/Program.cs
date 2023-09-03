// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

using System.ComponentModel.DataAnnotations;

Console.Write("Введите трехзначное число: ");
string num = Console.ReadLine()!;
SecondDigit(num);

void SecondDigit(string text)
{
    if (num.Length != 3)
    {
        Console.WriteLine("Введено не трехзначное число!");
    }
    else
    {
        int number = int.Parse(text);
        int firstDigit = number / 100;
        int secondDigit = number / 10 - firstDigit * 10;
        Console.WriteLine(secondDigit);
    }
}
