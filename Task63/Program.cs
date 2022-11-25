// Задача 63: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Write("Задайте число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NaturalNumber(number));

int NaturalNumber(int a)
{
    if(a == 1)
        return 1;
    else
    {
        Console.Write(NaturalNumber(a - 1) + ", ");
    }

    return a;
}

// с void методом
// Console.Write("Задайте число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// NaturalNumber(number);

// void NaturalNumber(int a)
// {
//     if(a == 1)
//         Console.Write(a + " ");
//     else
//     {
//         NaturalNumber(a - 1);
//         Console.Write(a + " ");
//     }
// }