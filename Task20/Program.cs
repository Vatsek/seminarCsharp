/*   Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53     */

int x1 = ReadInt("Введите X точки A: ");
int y1 = ReadInt("Введите Y точки A: ");
int z1 = ReadInt("Введите Z точки A: ");
int x2 = ReadInt("Введите X точки B: ");
int y2 = ReadInt("Введите Y точки B: ");
int z2 = ReadInt("Введите Z точки B: ");

int sqrLengthX = MultiplСoord(x1, x2);
int sqrLengthY = MultiplСoord(y1, y2);
int sqrLengthZ = MultiplСoord(z1, z2);

double distance = Math.Sqrt(sqrLengthX + sqrLengthY + sqrLengthZ);
Console.WriteLine("Расстояние равно " + distance);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int MultiplСoord (int a, int b)
{
    int result = (b - a) * (b - a);
    return result;
}