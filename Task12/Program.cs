/*Напишите программу, которая будет принимать на вход два числа и выводить,
 является ли первое число кратным второму. Если число 1 не кратно числу 2,
  то программа выводит остаток от деления.*/

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
int remainder = number1 % number2;

if (remainder == 0)
{
    Console.WriteLine($"Число {number1} кратно числу {number2}");
}
else 
{
    Console.WriteLine($"Число {number1} не кратно числу {number2}");
    Console.WriteLine($"Остаток от деления {remainder}");
}
