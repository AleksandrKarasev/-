/*
Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 12 10
*/

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