# Домашняя работа по семинару 2

## Задача 1
Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.

```C#
int FindSecond (int number)
{
    int result = (number / 10) % 10;
    return result;
}

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int res = FindSecond(num);
Console.WriteLine($"Вторая цифра числа : {num} - {res}");
```

## Задача 2
 Напишите программу, которая выводит
третью цифру заданного числа или сообщает, что третьей
цифры нет.

```C#
int FindThrid(int number)
{
 int res = number % 10;
return res;
}

int num = int.Parse(Console.ReadLine());
float check = num / 100;
if (check => 1)
{
    int result = FindThrid(num);
    Console.WriteLine($"Третья цифра числа {num} - {result}");
}
else
{
    Console.WriteLine("Нет");
}
```

## Задача 3
 Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.

```C#
void NumberWeek(int number)
{
    if (number == 6 | number == 7)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}


int num = int.Parse(Console.ReadLine());
NumberWeek(num);
```