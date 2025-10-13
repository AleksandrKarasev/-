/*
Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
*/

int proizvideni(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result = result * i;
    }
    return result;
}

int N = int.Parse(Console.ReadLine());
int res = proizvideni(N);
Console.WriteLine(res);