/*Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.*/

int number = new Random().Next(100, 1000);
int number1 = number / 100;
int number2 = number % 10;

Console.WriteLine($"Случайное число равно: {number}");
Console.WriteLine($"Первая цифра случайного числа {number1}");
Console.WriteLine($"Первая цифра случайного числа {number2}");
Console.WriteLine($"Число без второй цифры случайного числа будет {number1}{number2}");

