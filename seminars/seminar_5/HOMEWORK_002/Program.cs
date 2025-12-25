/*
Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях.
*/

void FullArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i] = new Random().Next(1, 1000);
    }
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i] + " ");
        Console.WriteLine();
    }
}

int k = int.Parse(Console.ReadLine());
int[] massiv = new int[k];
int sum = 0;
FullArray(massiv);
PrintArray(massiv);

for (int i = 0; i < massiv.GetLength(0); i++)
{
    if ((i + 1) % 2 != 0)
    {
        sum = sum + massiv[i];
    }
}

Console.WriteLine($"Сумма элементов стоящих на нечетных позициях {sum}");
