// Вид 1
void Method1()
{
    Console.WriteLine("Автор Карасёв Александр");
}
Method1();



// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

// Вид 2 но несколько аргументов

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method21("Текст", 4);



// Вид 3

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);


// Вид 4

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(4, "qwerty");
Console.WriteLine(res);

// Метод 41 с помощью цикла for 


string Method41(int count, string text)
{
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}


string res41 = Method41(4, "hello");
Console.WriteLine(res41);


// Таблица умножения

for (int i = 2; i < 10; i++)
{
    for (int j = 2; j < 10; j++)
    {
        Console.WriteLine($"{i}*{j}={i * j}");
    }
    Console.WriteLine();
}