/*
Напишите программу, которая
принимает на вход число (А) и выдаёт сумму чисел
от 1 до А.
*/

using System.Diagnostics;

int SUMNUMBER (int a )
{
    int result = 0;
    for (int i = 0; i <= a; i++)
    {
        result = result + i;
    }
    return result;
}

int A = int.Parse(Console.ReadLine());
int res = SUMNUMBER(A);
Console.WriteLine(res);