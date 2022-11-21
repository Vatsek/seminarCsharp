// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении 
// которых расположен наименьший элемент массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7





/*
решение в группе
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");

int[,] array = new int[rows, columns];
int[,] array1 = new int[array.GetLength(0)-1,array.GetLength(1)-1];
Fill2DArray(array);

int minI = 0;
int minJ = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i,j] < array[minI,minJ])
        {
            minI = i;
            minJ = j;
        }
    }
}
int indexRow = 0;
int indexColumn = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    if(i == minI)
            continue;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        if(j == minJ)
            continue;
        array1[indexRow, indexColumn] = array[i, j];
        indexColumn++;
    }
    indexColumn = 0;
    indexRow++;
}

Write2DArray(array);
Console.WriteLine();
Write2DArray(array1);

void Write2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int ReadInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void Fill2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
     for (int j = 0; j < numbers.GetLength(1); j++)
        {
        numbers[i, j] = new Random().Next(0, 10);
        }
    }
}

*/