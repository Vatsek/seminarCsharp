// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет 
// местами первую и последнюю строку массива.

int rows  = ReadMessage("Введите количество строк: ");
int columns = ReadMessage("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
int firstRow = 0;
int secondRow = numbers.GetLength(0) - 1;

Fill2DArrayRandomNumbers(numbers);
WriteArray(numbers);
Console.WriteLine();

for(int i = 0; i < numbers.GetLength(1); i++)
{
    int tempNumber = numbers[firstRow, i];
    numbers[firstRow, i] = numbers[secondRow, i];
    numbers[secondRow, i] = tempNumber;
}
WriteArray(numbers);

void Fill2DArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(1 , 10);
        }   
    }
}

void WriteArray(int[,] array)
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

int ReadMessage(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
