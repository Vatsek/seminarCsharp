/*Напишите программу, которая будет выдавать название дня недели по заданному номеру.*/


Console.WriteLine("Введите номер дня недели:");
string inputDay = Console.ReadLine();
string day1 = ("Понедельник");
string day2 = ("Вторник");
string day3 = ("Среда");
string day4 = ("Четверг");
string day5 = ("Пятница");
string day6 = ("Суббота");
string day7 = ("Воскресение");

if (Convert.ToInt32(inputDay) == 1)
{
    Console.WriteLine(day1);
}
else if (Convert.ToInt32(inputDay) == 2)
{
    Console.WriteLine(day2);
}
else if (Convert.ToInt32(inputDay) == 3)
{
    Console.WriteLine(day3);
}
else if (Convert.ToInt32(inputDay) == 4)
{
    Console.WriteLine(day4);
}
else if (Convert.ToInt32(inputDay) == 5)
{
    Console.WriteLine(day5);
}
else if (Convert.ToInt32(inputDay) == 6)
{
    Console.WriteLine(day6);
}
else if (Convert.ToInt32(inputDay) == 7)
{
    Console.WriteLine(day7);
}
else
{
    Console.WriteLine("Такого дня не существует");
}
