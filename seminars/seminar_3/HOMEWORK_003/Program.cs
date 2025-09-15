/*
 Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/

Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());


void cube (int n)
{
    for (int i = 1; i <= n; i++)
    {
        if (n > i)
        {
            Console.WriteLine(i * i + ",");
        }
        else
        {
            Console.WriteLine(i * i);
        }
    }
}

cube(N);