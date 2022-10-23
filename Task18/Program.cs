/*
Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат 
точек в этой четверти (x и y).
*/

Console.Write("Введите номер четверти: ");
int squareNumber = Convert.ToInt32(Console.ReadLine());

if(squareNumber == 1)
    Console.WriteLine("X > 0, Y > 0");
else if(squareNumber == 2)
    Console.WriteLine("X < 0, Y > 0");
else if(squareNumber == 3)
    Console.WriteLine("X < 0, Y < 0");
else if(squareNumber == 4)
    Console.WriteLine("X > 0, Y < 0");
else
    Console.WriteLine("Четвертей всего 4!");