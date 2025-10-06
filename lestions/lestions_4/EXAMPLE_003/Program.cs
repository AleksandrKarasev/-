int [,] FullArray(int countString, int countColumns)
{
    int[,] matrix = new int[countString, countColumns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(11, 20);
        }
    }
    return matrix;
}

int GetSumNumber(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}

bool isInteresting(int value)
{
    int SumNumber = GetSumNumber(value);
    if (SumNumber % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
int[,] matrix = FullArray(4, 8);

foreach (int e in matrix) 
{
    if (isInteresting(e) == true)
    {
        Console.WriteLine(e);
    }
}