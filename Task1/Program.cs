/*Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.*/


Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
int sqrA = numberA * numberA;

if (sqrA == numberB)
{
    Console.WriteLine("Число " + numberB + " является квадратом числа " + numberA);
}
else
{
    Console.WriteLine("Число " + numberB + " не является квадратом числа " + numberA);
}