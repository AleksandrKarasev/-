int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = new Random().Next(1, 1000);
Console.WriteLine(a1);
int b1 = new Random().Next(1, 1000);
Console.WriteLine(b1);
int c1 = new Random().Next(1, 1000);
Console.WriteLine(c1);

int a2 = new Random().Next(1, 1000);
Console.WriteLine(a2);
int b2 = new Random().Next(1, 1000);
Console.WriteLine(b2);
int c2 = new Random().Next(1, 1000);
Console.WriteLine(c2);   

int a3 = new Random().Next(1, 1000);
Console.WriteLine(a3);
int b3 = new Random().Next(1, 1000);
Console.WriteLine(b3);
int c3 = new Random().Next(1, 1000);
Console.WriteLine(c3);

int max1 = Max(a1, b1, c1);
Console.WriteLine(max1); 
int max2 = Max(a2, b2, c2);
Console.WriteLine(max2);
int max3 = Max(a3, b3, c3);
Console.WriteLine(max3);

int max = Max(max1, max2, max3);
Console.WriteLine($"max={max}");



