/*16. Напишите программу, которая принимает на
вход два числа и проверяет, является ли одно
число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет*/

void squard(int arg1, int arg2)
{
    if ((arg1 *arg1 == arg2) | (arg2 * arg2 == arg1))
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
Console.WriteLine("Введите первое число :");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число :");
int numberB = int.Parse(Console.ReadLine());
squard(numberA, numberB);