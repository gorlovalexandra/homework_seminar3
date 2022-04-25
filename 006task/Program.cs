/* 6. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. */

void Square(int N)
{
    int Sq = 1;
    for (Sq = 1; Sq <= N; Sq++)
        Console.WriteLine(Sq * Sq * Sq);
}

Square(3);
Console.WriteLine();
