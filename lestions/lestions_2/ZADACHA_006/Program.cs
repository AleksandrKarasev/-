void FillArray(int[] collection)
{
    int len = collection.Length;
    int i = 0;
    while (i < len)
    {
        collection[i] = new Random().Next(1, 10);
        i++;
    }
}

void PrintArray(int[] col)
{
    int length = col.Length;
    int j = 0;
    while (j < length)
    {
        Console.WriteLine(col[j]);
        j++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
int pos = IndexOf(array, 4);
Console.WriteLine();
Console.WriteLine(pos);