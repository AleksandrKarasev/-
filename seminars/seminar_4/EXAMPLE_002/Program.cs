/*
Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
*/

Console.Write("Введите число: ");
string input = Console.ReadLine();        
int digitCount = CountDigits(input);
Console.WriteLine("Количество цифр в числе: " + digitCount);

int CountDigits(string number)
    {
        return number.Length; // Возвращаем количество цифр
    }