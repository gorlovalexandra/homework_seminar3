/* 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве. */

double Distance(double x1, double y1, double x2, double y2)
{
    double X = Math.Abs(x1 - x2);
    double Y = Math.Abs(y1 - y2);
    double XY = Math.Sqrt((X * X) + (Y * Y));
    return XY;
}

double AX = 7;
double AY = -5;
double BX = 1;
double BY = -1;

Console.WriteLine(Math.Round(Distance(AX, AY, BX, BY), 2));
