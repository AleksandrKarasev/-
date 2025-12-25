/*
Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

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