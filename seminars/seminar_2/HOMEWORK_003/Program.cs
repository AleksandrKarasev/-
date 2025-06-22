/*Задача 15: Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.
*/

void NumberWeek(int number)
{
    if (number == 6 | number == 7)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}


int num = int.Parse(Console.ReadLine());
NumberWeek(num);