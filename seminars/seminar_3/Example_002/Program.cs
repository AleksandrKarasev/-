/*Напишите программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта
точка.
*/

Console.WriteLine("Введите координату X: ");
        int positionX = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите координату Y: ");
        int positionY = int.Parse(Console.ReadLine());

        int diaposon = quart(positionX, positionY);
        
        if (diaposon != 0)
        {
            Console.WriteLine($"Четверть: {diaposon}");
        }
        else
        {
            Console.WriteLine("Координаты находятся на оси или в начале координат.");
        }

    static int quart(int X, int Y)
    {
        if (X > 0 && Y > 0)
        {
            return 1; // Первая четверть
        }
        else if (X < 0 && Y > 0)
        {
            return 2; // Вторая четверть
        }
        else if (X < 0 && Y < 0)
        {
            return 3; // Третья четверть
        }
        else if (X > 0 && Y < 0)
        {
            return 4; // Четвертая четверть
        }
        
        return 0; // Координаты на осях
    }

