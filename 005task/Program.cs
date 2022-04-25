/* 5. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. */

double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double X = Math.Abs(x1 - x2);
    double Y = Math.Abs(y1 - y2);
    double Z = Math.Abs(z1 - z2);
    double XYZ = Math.Sqrt((X * X) + (Y * Y) + (Z * Z));
    return XYZ;
}

double AX = 3;
double AY = 6;
double AZ = 8;
double BX = 2;
double BY = 1;
double BZ = -7;

Console.WriteLine(Math.Round(Distance(AX, AY, AZ, BX, BY, BZ), 2));
