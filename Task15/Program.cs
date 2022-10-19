/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
 является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите номер дня недели: ");
int inputDay = Convert.ToInt32(Console.ReadLine());

if (inputDay > 0 && inputDay < 6)
{
    Console.WriteLine("Это рабочий день");
}
else if (inputDay > 5 && inputDay < 8)
{
    Console.WriteLine("Это выходной");
}
else
{
        Console.WriteLine("Такого дня недели не существует");
}