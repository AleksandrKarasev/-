// Напиши программу которая на вход принимает трехзначное число и выводит
// последнюю цифру

int number = int.Parse(Console.ReadLine());
int info = number % 10;
Console.WriteLine($"Последняя цифра {info}");