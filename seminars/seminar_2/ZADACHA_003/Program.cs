/*14. Напишите программу, которая принимает на
вход число и проверяет, кратно ли оно
одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/

void crat_7_23(int number)
{
    if ((number % 7 == 0) & (number % 23 == 0))
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}

int number = int.Parse(Console.ReadLine());
crat_7_23(number);