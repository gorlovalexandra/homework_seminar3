/* 4. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. */

void Palindrome(int N)
{
    if ((N % 10 == N / 10000) && ((N % 100) / 10 == (N / 1000) % 10))
    {
        Console.WriteLine("yes");
    }
    else
    {
        Console.WriteLine("no");
    }
}

Palindrome(12821);
Console.WriteLine();