// Напишите, программу которая на вход принимает одно число (N), 
//вывести все целые числа от -N до N

int numberA = int.Parse(Console.ReadLine());
int count = -numberA;
Console.Write(count);

while (numberA >= count) {
    Console.WriteLine(count);
    count++;
}