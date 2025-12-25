/* 
Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.
*/

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