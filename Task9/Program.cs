/*Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.*/

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число равно {number}");
int number1 = number / 10;
int number2 = number % 10;
Console.WriteLine($"Первая цифра {number1}, вторая цифра {number2}");
if (number1 > number2)
{
    Console.WriteLine($"Число {number1} больше числа {number2}");
}
else
{
    Console.WriteLine($"Число {number2} больше числа {number1}");
}