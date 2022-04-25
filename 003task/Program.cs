/* 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N. */

void Square(int N)
{
    int Sq = 1;
    for (Sq = 1; Sq <= N; Sq++)
        Console.WriteLine(Sq * Sq);
}

Square(5);
Console.WriteLine();
