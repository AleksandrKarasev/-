/*Задача 13: Напишите программу, которая выводит
третью цифру заданного числа или сообщает, что третьей
цифры нет.
*/

int FindThrid(int number)
{
 int res = number % 10;
return res;
}

int num = int.Parse(Console.ReadLine());
float check = num / 100;
if (check => 1)
{
    int result = FindThrid(num);
    Console.WriteLine($"Третья цифра числа {num} - {result}");
}
else
{
    Console.WriteLine("Нет");
}