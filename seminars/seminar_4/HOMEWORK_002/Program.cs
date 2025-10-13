/*
Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.
*/

int SumNumbers(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}

int N = int.Parse(Console.ReadLine());
int result = SumNumbers(N);
Console.WriteLine(result);