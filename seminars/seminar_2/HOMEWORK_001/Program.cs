 /*Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.
*/

int FindSecond (int number)
{
    int result = (number / 10) % 10;
    return result;
}

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int res = FindSecond(num);
Console.WriteLine($"Вторая цифра числа : {num} - {res}");