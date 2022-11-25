// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int rows = RedInt("Задайте количество строк: ");
int columns = RedInt("Задайте количество колонок: ");

if (rows != columns)
{
    Console.WriteLine("Заполнить спирально можно только квадратный массив. Кол-во строк должно равняться кол-ву столбцов");
    return;
}

int[,] numbers = new int[rows, columns];
int value = 1;
int i = 0;
int j = 0;

while (value <= rows * columns)
{
    numbers[i, j] = value++;
    if (i <= j + 1 && i + j < rows - 1)
        j++;
    else if (i < j && i + j >= columns - 1)
        i++;
    else if (i >= j && i + j > rows - 1)
        j--;
    else
        i--;
}
writeArray(numbers);

void writeArray(int[,] spiralArray)
{
    for (int i = 0; i < spiralArray.GetLength(0); i++)
    {
        for (int j = 0; j < spiralArray.GetLength(1); j++)
        {
            Console.Write(spiralArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int RedInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}