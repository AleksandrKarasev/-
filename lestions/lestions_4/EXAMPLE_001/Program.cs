/*
Создать двуменрный массив с размерами 3*5, состоявщего из целых чисел вывести его элементы на экран
*/


int[,] matrix = new int[3, 5];
Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rnd.Next(1, 15);
    }
}


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}