/*
Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным
элементов массива.
*/

void FullArray (int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i] = new Random().Next(1, 1000);
    }
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int k = int.Parse(Console.ReadLine());
int[] massiv = new int[k];
FullArray(massiv);
PrintArray(massiv);




int FindMin(int[] arr)
    {
        int min = arr[0]; // Начнем с первого элемента
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        return min;
    }

// Функция нахождения максимального элемента
 int FindMax(int[] arr)
{
    int max = arr[0]; // Начнем с первого элемента
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

int min = FindMin(massiv);
int max = FindMax(massiv);

int diff = max - min;

Console.WriteLine($"Максимальное число {max}; Минимальное число {min}; Разница {diff}");