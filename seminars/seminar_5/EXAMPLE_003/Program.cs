/*
Задача 33: Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

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