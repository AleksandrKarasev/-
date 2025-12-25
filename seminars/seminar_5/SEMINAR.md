# Семинар № 5 

## Задача № 1 
### Условие

Задача 31: Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. Найдите сумму
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
-20.

### Решение 

```C#
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i] = new Random().Next(-10, 10);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine(array[i]);
    }
}

void sumNumber(int[] massiv)
{
    int sum_plus = 0;
    int sum_minus = 0;
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        if (massiv[i] > 0)
        {
            sum_plus = sum_plus + massiv[i];
        }
        else
        {
            sum_minus = sum_minus + massiv[i];
        }
    }
    Console.WriteLine($"Сумма положительных чисел {sum_plus}");
    Console.WriteLine($"Сумма отрицательных чисел {sum_minus}");
}
int k = int.Parse(Console.ReadLine());
int[] matrix = new int[k];

FillArray(matrix);
PrintArray(matrix);
sumNumber(matrix);
```

## Задача 2 

### Условие
Задача 32: Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.


### Решение

```C#
using System;

class Program
{
    static void Main()
    {
        // Запрашиваем количество элементов массива у пользователя
        Console.Write("Введите размер массива: ");

        if (!int.TryParse(Console.ReadLine(), out int size))
        {
            Console.WriteLine("Ошибка: неверный ввод размера.");
            return;
        }

        // Создаем массив указанного размера
        int[] array = new int[size];

        // Заполняем массив случайными числами
        FillArray(array);

        // Показываем исходный массив
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Меняем знаки всех элементов
        ChangeSigns(array);

        // Показываем изменённый массив
        Console.WriteLine("\nИзмененный массив:");
        PrintArray(array);
    }

    // Функция заполнения массива случайными значениями
    static void FillArray(int[] array)
    {
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-10, 10); // генерируем числа от -10 до 9 включительно
        }
    }

    // Функция вывода массива
    static void PrintArray(int[] array)
    {
        foreach (var num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine(); // переход на новую строку
    }

    // Функция замены знаков каждого элемента массива
    static void ChangeSigns(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] *= -1; // меняем знак текущего элемента
        }
    }
}
```

## Задача 3 

### Условие
Задача 33: Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да

### Решение 
```C#
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        Console.WriteLine(arr[j]);
    }
}

int k = int.Parse(Console.ReadLine());
int[] array = new int[k];
FillArray(array);
int l = int.Parse(Console.ReadLine());
for (int m = 0; m < array.GetLength(0); m++)
{
    if (l == array[m])
    {
        Console.WriteLine("Да");
    }
    else Console.WriteLine("Нет");
}
```

## Задача 4

### Условие
Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5

### Решение
```C#
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i] = new Random().Next(0, 124);
    }
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        Console.WriteLine(arr[j]);
    }
}

int k = int.Parse(Console.ReadLine());
int[] array = new int[k];
FillArray(array);
int l = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    if (array[i] >= 10 & array[i] <= 99)
    {
        l++;
    }
}
Console.WriteLine(l);
```

## Задача 5

### Условие
Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 12 10


### Решение
```C#
using System;

class Program
{
    static void Main(string[] args)
    {
        // Получаем размер массива от пользователя
        Console.Write("Введите размер массива: ");
        string input = Console.ReadLine();
        int n;
        bool isValidInput = Int32.TryParse(input, out n);
        
        if (!isValidInput || n <= 0)
        {
            Console.WriteLine("Некорректный ввод!");
            return;
        }

        // Создаем массив заданного размера
        int[] array = new int[n];
        
        // Заполняем массив случайными числами
        FillArray(array);
        
        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        PrintArray(array);
        
        // Формируем новый массив произведений пар
        int[] result = MultiplyPairs(array);
        
        // Выводим результирующий массив
        Console.WriteLine("\nРезультат:");
        PrintArray(result);
    }

    // Метод заполнения массива случайными числами
    static void FillArray(int[] arr)
    {
        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(1, 10); // Числа от 1 до 9
        }
    }

    // Метод вывода массива на экран
    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
    }

    // Метод вычисления произведения пар элементов массива
    static int[] MultiplyPairs(int[] arr)
    {
        int length = arr.Length / 2 + arr.Length % 2; // Длина результирующего массива
        int[] result = new int[length];               // Новый массив для хранения произведений

        for (int i = 0; i < length; i++)
        {
            if (i == arr.Length - i - 1)   // Обрабатываем середину массива отдельно
                result[i] = arr[i];
            else
                result[i] = arr[i] * arr[arr.Length - i - 1]; // Умножение пары
        }

        return result;
    }
}
```

# Домашняя работа

## Задание 1 

### Условие 
Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.

### Решение 
```C#
using System.ComponentModel.Design;

void FullArray (int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i] = new Random().Next(100, 999);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i] + " ");
    }
}
Console.WriteLine("Сколько будет элементов в массиве?");
int k = int.Parse(Console.ReadLine());
int[] massiv = new int[k];
Console.WriteLine("Массив :");

FullArray(massiv);
PrintArray(massiv);

int Chet = 0;
int Nechet = 0;
for (int i = 0; i < massiv.GetLength(0); i++)
{
    if (massiv[i] % 2 == 0)
    {
        Chet = Chet + 1;
    }
    else
    {
        Nechet = Nechet + 1;
    }
}

Console.WriteLine($"Количество четных чисел {Chet}; Количестово нечетных чисел {Nechet}");
```

## Задание 2

### Условие 
Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.

### Решение 
```C#
using System.ComponentModel.Design;

void FullArray (int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i] = new Random().Next(100, 999);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i] + " ");
    }
}
Console.WriteLine("Сколько будет элементов в массиве?");
int k = int.Parse(Console.ReadLine());
int[] massiv = new int[k];
Console.WriteLine("Массив :");

FullArray(massiv);
PrintArray(massiv);

int Chet = 0;
int Nechet = 0;
for (int i = 0; i < massiv.GetLength(0); i++)
{
    if (massiv[i] % 2 == 0)
    {
        Chet = Chet + 1;
    }
    else
    {
        Nechet = Nechet + 1;
    }
}

Console.WriteLine($"Количество четных чисел {Chet}; Количестово нечетных чисел {Nechet}");
```

## Задание 3

### Условие
Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.

### Решение
```C#
using System.ComponentModel.Design;

void FullArray (int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i] = new Random().Next(100, 999);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i] + " ");
    }
}
Console.WriteLine("Сколько будет элементов в массиве?");
int k = int.Parse(Console.ReadLine());
int[] massiv = new int[k];
Console.WriteLine("Массив :");

FullArray(massiv);
PrintArray(massiv);

int Chet = 0;
int Nechet = 0;
for (int i = 0; i < massiv.GetLength(0); i++)
{
    if (massiv[i] % 2 == 0)
    {
        Chet = Chet + 1;
    }
    else
    {
        Nechet = Nechet + 1;
    }
}

Console.WriteLine($"Количество четных чисел {Chet}; Количестово нечетных чисел {Nechet}");
```