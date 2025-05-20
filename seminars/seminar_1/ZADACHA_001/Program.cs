// Напишите программу, которая на вход принимает число и выводит квадрат этого числа

Console.WriteLine("Введите число :");
int number = int.Parse(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадарт числа {number} равен {square}");