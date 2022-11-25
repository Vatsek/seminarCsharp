// Задача 65: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


Console.Write("Задайте число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Задайте число n: ");
int n = int.Parse(Console.ReadLine()!);
 
NaturalNumber(m, n);
 
void NaturalNumber(int m, int n)
{
    if (m < n)
    {
        Console.Write($"{m}, ");
        NaturalNumber(m + 1, n);
    }
    else if (m > n)
    {
        Console.Write($"{m}, ");
        NaturalNumber(m - 1, n);
    }
    else
    {
        Console.Write($"{m} ");
    }
}