int a = new Random().Next(1, 100);
Console.WriteLine(a);
int b = new Random().Next(1, 100);
Console.WriteLine(b);
int c = new Random().Next(1, 100);
Console.WriteLine(c);
int d = new Random().Next(1, 100);
Console.WriteLine(d);
int e = new Random().Next(1, 100);
Console.WriteLine(e);
int f = new Random().Next(1, 100);
Console.WriteLine(f);
int g = new Random().Next(1, 100);
Console.WriteLine(g);
int h = new Random().Next(1, 100);
Console.WriteLine(h);
int i = new Random().Next(1, 100);
Console.WriteLine(i);

int max = a;
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
if (d > max)
{
    max = d;
}
if (e > max)
{
    max = e;
}
if (f > max)
{
    max = f;
}
if (g > max)
{
    max = g;
}
if (h > max)
{
    max = h;
}
if (i > max)
{
    max = i;
}

Console.WriteLine($"max={max}");