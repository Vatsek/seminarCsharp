/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
*/

/*
int size = ReadInt("Введтие размер массива: ");
int[] numbers = new int[size];
FillArrayRundomNumbers(numbers);
WriteArray(numbers);

int searchNumber = ReadInt("Введтие искомое число: ");
for(int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == searchNumber)
    {
        Console.WriteLine("Да");
        return;
    }
}
Console.WriteLine("Нет");

void FillArrayRundomNumbers(int[] array, int min = 1, int max = 9)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int size = ReadInt("Введтие размер массива: ");
int[] numbers = new int[size];
FillArrayRundomNumbers(numbers);
WriteArray(numbers);

int searchNumber = ReadInt("Введтие искомое число: ");
string output = "Нет";
for(int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == searchNumber)
    {
        output = "Да";
        break;
    }
}
Console.WriteLine(output);

void FillArrayRundomNumbers(int[] array, int min = 1, int max = 9)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

*/

int size = ReadInt("Введтие размер массива: ");
int[] numbers = new int[size];
FillArrayRundomNumbers(numbers);
WriteArray(numbers);

int searchNumber = ReadInt("Введтие искомое число: ");

if(IsExist(numbers, searchNumber))
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");

bool IsExist(int[] array, int number)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == searchNumber)
        {
            return true;
        }
    }
    return false;
}

void FillArrayRundomNumbers(int[] array, int min = 1, int max = 9)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}