/*  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да    */

int number = ReadInt("Введите пятизначное число: ");
int tempNumber = number;
int digit = 0;
int sum = 0;

if (number > 9999 && number < 100000)
{
    while (number > 0)
    {
            digit = number % 10;
            sum = (sum * 10) + digit;
            number /=10;
    }
}
else
{
    Console.WriteLine("Введено не пятизначное число: ");
    return;
}
if (tempNumber == sum)
{
    Console.WriteLine($"Число {tempNumber} является полиндромом");
}
else
    Console.WriteLine($"Число {tempNumber} не является полиндромом");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}