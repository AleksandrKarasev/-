/*
Задача 31: Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. Найдите сумму
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
-20.
*/

using System.Diagnostics;

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