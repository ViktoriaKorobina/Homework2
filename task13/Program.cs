// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
string num = Console.ReadLine();
ThirdDigit(num);

void ThirdDigit(string text)
{
    bool result = int.TryParse(text, out int number);
    if (result == true)
    {
        int length = text.Length;
        if (length < 3) Console.WriteLine("Третьей цифры нет.");
        else
        {
            if (length == 3) Console.WriteLine(number % 10);
            else
            {
                int temp1 = 10;
                int temp2 = 10;
                for (int i = 1; i < length - 2; i++)
                {
                    temp1 *= 10;
                }
                for (int i = 1; i < length - 3; i++)
                {
                    temp2 *= 10;
                }
                int thirdDigit = number / temp2 - number / temp1 * 10;
                Console.WriteLine(thirdDigit);
            }
        }
    }
    else
    {
        Console.WriteLine("Введено не число!");
    }
}