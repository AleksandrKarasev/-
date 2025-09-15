/*
Напишите программу, которая
принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N.
*/

Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    int k = i*i;
    if (k != N)
    {
        Console.Write($"{k}");
        Console.Write(",");
    }
    else if (k==N)
    {
        Console.Write(k);
    }
}