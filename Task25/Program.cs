/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/


int numberA = ReadInt("Введите число, которое хотите возвести в степень: ");

int numberB = ReadInt("Введите число,в какую степень Вы хотите возвести число A: ");

int result = 1;

for (int i = 1; i <= numberB; i++)
{
    result *= numberA;
}
Console.WriteLine($"Результат равен {result}");


int ReadInt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}