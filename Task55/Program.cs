// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

int rows  = ReadMessage("Введите количество строк: ");
int columns = ReadMessage("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
int[,] reverseNumbers = new int[columns, rows];

Fill2DArrayRandomNumbers(numbers);
WriteArray(numbers);
Console.WriteLine();

for (int i = 0; i < reverseNumbers.GetLength(0); i++)
{
    for (int j = 0; j < reverseNumbers.GetLength(1); j++)
    {
        reverseNumbers[i, j] = numbers[j, i];
    }   
}
WriteArray(reverseNumbers);

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