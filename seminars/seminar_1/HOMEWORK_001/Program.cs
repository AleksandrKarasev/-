//Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());
int max = 0;
int min = 0;
if (numberA > numberB)
{
    max = numberA;
     min = numberB;
}
if (numberB > numberA)
{
     max = numberB;
     min = numberA;
}

Console.WriteLine($"max={max}, min={min}");
