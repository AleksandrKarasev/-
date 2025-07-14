int[] arr = { 1, 5, 4, 3, 6, 2, 3, 8, 10, 22, 1, 45, 444 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
}

PrintArray(arr);

void SelectedArray(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
SelectedArray(arr);
PrintArray(arr);