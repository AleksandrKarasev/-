/*
 Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.
*/

int[] massiv = new int[8];
Random rnd = new Random();
for (int i = 0; i < massiv.GetLength(0); i++)
{
    massiv[i] = rnd.Next(1, 100);
}

for (int i = 0; i < massiv.GetLength(0); i++)
{
    Console.WriteLine($"{massiv[i]} ,");
}