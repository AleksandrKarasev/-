/*Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.
*/

double stepen(int numberA, int numberB)
{
    double result = Math.Pow(numberA, numberB);
    return result;
}

int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
double res = stepen(A, B);
Console.WriteLine(res);
