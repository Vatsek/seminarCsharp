// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.

// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
int a = ReadInt("Введите длину первой стороны: ");  
int b = ReadInt("Введите длину второй стороны: ");    
int c = ReadInt("Введите длину третьей стороны: ");  

if (CheckSide(a, b, c) && CheckSide(b, a, c) && CheckSide(c, b, a))
{
    Console.WriteLine("Три числа являются сторонами треугольника");
}
else
{
    Console.WriteLine("Три числа НЕ являются сторонами треугольника");
}

bool CheckSide(int checkingSide, int first, int second)
{
    return checkingSide < first + second;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

