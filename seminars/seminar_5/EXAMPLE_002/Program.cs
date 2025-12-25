/*
Задача 32: Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
*/

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

