// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] numbers = new int[3, 4];

Random rand = new Random();

Fill2DArray(numbers);

Console.WriteLine("Заданный массив:");

Write2DArray(numbers);

int size = numbers.GetLength(1);

double[] middle = new double[size];

for (int i = 0; i < size; i++)
{
    middle[i] = middleInColumn(numbers, i);
}

Console.WriteLine("Cреднее арифметическое элементов в каждом столбце:");
WriteArray(middle);



// Вывод массива в консоль
void WriteArray(double[] writeArray)
{
for (int i = 0; i < writeArray.Length; i++)
{
    Console.Write(Math.Round(writeArray[i], 1) + " | ");
}
}

// Нахождение среднего значения в колонке 2D массива
double middleInColumn(int[,] arrayColumn, int rows)
{
    double sum = 0;

    for (int i = 0; i < arrayColumn.GetLength(0); i++)
    {
        sum += numbers[i, rows];
    }
    double middle = sum / arrayColumn.GetLength(0);

    return middle;
}

// заполнение 2D массива
void Fill2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(0, 10);
        }
    }
}

// Вывод в консоль 2D массива
void Write2DArray(int[,] printArray)
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
