// Напишите программу, которая на вход принимает два числа и проверяет
// является ли первое число квадратом первого

int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());
if (numberB * numberB == numberA)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}