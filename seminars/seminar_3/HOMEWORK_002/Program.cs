/*
Напишите программу, которая принимает на
вход координаты двух точек и находит расстояние
между ними в 3D пространстве.
*/

Console.WriteLine("Введите кординату x для точки A");
int XA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кординату y для точки A");
int YA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кординату z для точки A");
int ZA =int.Parse(Console.ReadLine());
Console.WriteLine("Введите кординату x для точки B");
int XB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кординату y для точки B");
int YB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кординату z для точки B");
int ZB = int.Parse(Console.ReadLine());


double distans (int xa, int ya,  int za,  int xb, int yb, int zb)
{
    int xab = xb - xa;
    int yab = yb - ya;
    int zab = zb - za;
    int sqrtxab = xab * xab;
    int sqrtyab = yab * yab;
    int sqrtzab = zab * zab;
    double result = Math.Sqrt(sqrtxab + sqrtyab + sqrtzab);
    return result;
}

double res = distans(XA, YA, ZA, XB, YB, ZB);
Console.WriteLine(res);