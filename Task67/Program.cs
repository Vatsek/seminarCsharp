// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


Console.Write("Введите любое число: ");
int number = int.Parse(Console.ReadLine());  
Console.WriteLine("Сумма цифр заданного числа равна: " + Sum(number));

int Sum(int a)
{
    if (a > 0) 
        return a % 10 + Sum(a / 10);
    
    return 0;
}