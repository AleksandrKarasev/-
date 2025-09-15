/*Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом.
*/

Console.WriteLine("Введите пятизначное число");
string input = Console.ReadLine();

void isPalidrom(string str)
{
    if (str[0] == str[4] && str[1] == str[3])
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("NO");
    }
}

isPalidrom(input); 