/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.*/

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int result = number % 10;
Console.WriteLine(result);