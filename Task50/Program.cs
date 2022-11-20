// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет. 
//Во вводе первая цифра - номер строки, вторая - столбца.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] numbers = new int[3, 4];

Random rand = new Random();

FillArray(numbers);

Console.WriteLine("Заданный массив:");

WriteArray(numbers);

Console.WriteLine("Введите число, позицию искомого элемента в двухмерном массиве,");
Console.Write("где первая цифра - номер строки, а вторая - номер столбца: ");
Console.WriteLine();

string searchPositionNumber = Console.ReadLine();


if(CheckInputNumber(searchPositionNumber))
    return;


WriteElement2DArray(numbers, searchPositionNumber);


void WriteElement2DArray(int[,] writeElementArray, string text)
{
    int searchPositionNumber = Convert.ToInt32(text);
    
    int columns = searchPositionNumber % 10;

    int rows = (searchPositionNumber / 10) % 10;

    if (writeElementArray.GetLength(0)-1  < rows || writeElementArray.GetLength(1)-1 < columns)
        Console.WriteLine($"Под индексом ({rows},{columns}) элемента в массиве нет");
    
    else
        Console.WriteLine($"Под индексом ({rows},{columns}) находится элемент со значением {numbers[rows, columns]}");
}


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(0, 10);
        }
    }
}

void WriteArray(int[,] printArray)
{
    for (int i = 0; i < printArray.GetLength(0); i++)
    {
        for (int j = 0; j < printArray.GetLength(1); j++)
        {
            Console.Write($"{printArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

bool CheckInputNumber(string searchPositionNumber)
{
    
    bool result = searchPositionNumber.Length != 2;
    if(result == true)
        Console.WriteLine("Исходя из условий задачи, вводимое число может быть только двузначным");
    
    return result;
}