/*Напиште программу, которая по заданному номеру четверти,
 показывает диапозон возможных кординат 
 точек в этой четверти x и y
*/

Console.WriteLine("Введите номер четверти:");
int num = int.Parse(Console.ReadLine());


void diaposon(int number)
{
    if (number == 1)
    {
        Console.WriteLine("X>0; Y>0");
    }
    if (number == 2)
    {
        Console.WriteLine("X<0 Y>0");
    }
    if (number == 3)
    {
        Console.WriteLine("X<0 Y<0");
    }
    if (number == 4)
    {
        Console.WriteLine("X>0 Y<0");
    }
}


diaposon(num);