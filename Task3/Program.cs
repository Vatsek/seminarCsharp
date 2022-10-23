/*Напишите программу, которая будет выдавать название дня недели по заданному номеру.*/


Console.WriteLine("Введите номер дня недели:");
int inputDay = Convert.ToInt32(Console.ReadLine());
string day1 = ("Понедельник");
string day2 = ("Вторник");
string day3 = ("Среда");
string day4 = ("Четверг");
string day5 = ("Пятница");
string day6 = ("Суббота");
string day7 = ("Воскресение");

if (inputDay == 1)
{
    Console.WriteLine(day1);
}
else if (inputDay == 2)
{
    Console.WriteLine(day2);
}
else if (inputDay == 3)
{
    Console.WriteLine(day3);
}
else if (inputDay == 4)
{
    Console.WriteLine(day4);
}
else if (inputDay == 5)
{
    Console.WriteLine(day5);
}
else if (inputDay == 6)
{
    Console.WriteLine(day6);
}
else if (inputDay == 7)
{
    Console.WriteLine(day7);
}
else
{
    Console.WriteLine("Такого дня не существует");
}
