/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Write("Введите трёхзначное число: ");

int inputNumber = Convert.ToInt32(Console.ReadLine());

if (CheckBitDepth(inputNumber))
{
    return;
}

int secondFigure = inputNumber / 10 % 10;

Console.WriteLine($"Вторая цифра числа {inputNumber} = {secondFigure}");


bool CheckBitDepth(int number)
{
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count++;
    }
    if (count != 3)
    {
        Console.WriteLine("Введено не трехначное число");
        return true;
    }
    else
        return false;
    
}