/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите число: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());

if (inputNumber < 100)
{
    Console.WriteLine("третьей цифры нет");
    }
else
{
    while (inputNumber > 1000)
    {
    inputNumber = inputNumber / 10;
    }
int result = inputNumber % 10;
Console.WriteLine(result);
}
