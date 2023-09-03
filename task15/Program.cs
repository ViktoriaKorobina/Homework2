// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число, обозначающее день недели: ");
string day = Console.ReadLine();
DayOff(day);

void DayOff(string text)
{
    bool result = int.TryParse(text, out int number);
    if (result == true)
    {
        if(number == 1 ||
        number == 2 ||
        number == 3 ||
        number == 4 ||
        number == 5) Console.WriteLine("Нет");
        else if(number == 6 || number == 7) Console.WriteLine("Да");
        else Console.WriteLine("Нет такого дня недели!");
    }
    else Console.WriteLine("Введено не число!");
}