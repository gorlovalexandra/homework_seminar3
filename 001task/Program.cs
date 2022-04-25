/* 1. Напишите программу, которая принимает на вход координаты точки (X и Y),
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка. */

void Quarter(double X, double Y)
{
    if (X == 0 && Y == 0)
    {
        Console.WriteLine("Enter X, Y > 0");
    }

    if (X > 0 && Y > 0)
    {
        Console.WriteLine("I quarter");
    }

    if (X < 0 && Y > 0)
    {
        Console.WriteLine("II quarter");
    }

    if (X < 0 && Y < 0)
    {
        Console.WriteLine("III quarter");
    }
    if (X > 0 && Y < 0)
    {
        Console.WriteLine("IV quarter");
    }
}

Quarter(3, 6);
Console.WriteLine();