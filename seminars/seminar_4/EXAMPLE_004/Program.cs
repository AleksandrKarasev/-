/*
Напишите программу, которая
выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
*/

Random rnd = new Random();

int[] matrix = new int[8];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    matrix[i] = rnd.Next(0, 2);
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    Console.WriteLine($"{matrix[i]},");
}
