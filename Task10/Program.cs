/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Write("Введите трёхзначное число: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());
int secondFigure = inputNumber / 10 %10;
Console.WriteLine($"Вторая цифра числа {inputNumber} = {secondFigure}");