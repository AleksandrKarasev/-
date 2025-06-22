/*
11. Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает вторую
цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int second(int number)
{
    int second = (number / 10) % 10;
    return second;
}

int number = int.Parse(Console.ReadLine());
int result = second(number);
Console.WriteLine(result);