/* 9. Напишите программу, которая выводит
случайное число из отрезка [10, 99] и показывает
наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8
*/

int Max(int random)
{
    int first = random / 10;
    int second = random % 10;
    int max = first;
    if (second > max) max = second;
    return max;
}


int random = new Random().Next(10, 99);
int maximum = Max(random);
Console.WriteLine(random);
Console.WriteLine($"maximum={maximum}");