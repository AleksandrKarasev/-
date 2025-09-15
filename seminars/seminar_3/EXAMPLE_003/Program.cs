/*Напишите программу, которая
принимает на вход координаты двух
точек и находит расстояние между ними в
2D пространстве.
*/





Console.WriteLine("Введите координату X точки A");
int positionXA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y точки A");
int positionYA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату X точки B");
int positionXB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B");
int positionYB = int.Parse(Console.ReadLine());

double diastantion (int XA, int YA, int XB, int YB)
{
    int XAB = XB - XA;
    int YAB = YB - YA;
    int sqrtXAB = XAB*XAB;
    int sqrtYAB = YAB * YAB;
    double result = Math.Sqrt(sqrtXAB + sqrtYAB);
    return result;
}

double res = diastantion(positionXA, positionYA, positionXB, positionYB);
Console.WriteLine(res);

