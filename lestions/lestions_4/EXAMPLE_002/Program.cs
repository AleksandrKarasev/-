int [,] FullArray(int countString, int countColumns)
{
    int[,] matrix = new int[countString, countColumns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j< matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 20);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}  ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = FullArray(3, 5);
PrintArray(matrix);