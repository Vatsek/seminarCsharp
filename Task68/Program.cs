// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите два неотрицательных числа M и N для вычесления функции Аккермана");
int m = ReadInt("Введите число M: ");
int n = ReadInt("Введите число N: ");

if (m < 0 || n < 0)
{
    Console.WriteLine("Для вычесления функции Аккермана числа должны быть положительными");
    return;
}
int result = ackermannFunction(m, n);
Console.WriteLine(result);


int ackermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return ackermannFunction(m - 1, 1);
    }
    else
    {
        return ackermannFunction((m - 1), ackermannFunction(m, n - 1));
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}