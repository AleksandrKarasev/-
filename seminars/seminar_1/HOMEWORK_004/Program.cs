int number = int.Parse(Console.ReadLine());
int count = 1;
while (number >= count)
{
    if (count % 2 == 0)
    {
        Console.WriteLine(count);
    }
    count++;
}