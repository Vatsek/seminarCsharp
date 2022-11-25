// Задача 60. ...Сформируйте трёхмерный массив из случайных неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int depth = ReadInt("Введите глубину: ");
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");

int[,,] numbers = new int[depth, rows, columns];

int min = 10;
int max = 100;

Random rand = new Random();

int[] randomNumbers = new int[max - min];

if (numbers.Length > max)
{
    Console.WriteLine("Массив из случайных неповторяющихся двузначных чисел такого размера невозможен");
    return;
}

FillArrayNumbers(randomNumbers);

Shuffle(randomNumbers);

Fill3DArrayNumbersFromArray(numbers, randomNumbers);

Write3DArray(numbers);

void Fill3DArrayNumbersFromArray(int[,,] fillArray, int[] randNumbers)
{
    int indexArrayRandomNumbers = 0;
    for (int i = 0; i < fillArray.GetLength(0); i++)
    {
        for (int j = 0; j < fillArray.GetLength(1); j++)
        {
            for (int k = 0; k < fillArray.GetLength(2); k++)
            {
                fillArray[i, j, k] = randNumbers[indexArrayRandomNumbers++];
            }
        }
    }
}

void Write3DArray(int[,,] writeArray)
{
    for (int k = 0; k < writeArray.GetLength(2); k++)
    {
        for (int i = 0; i < writeArray.GetLength(0); i++)
        {
            for (int j = 0; j < writeArray.GetLength(1); j++)
            {
                Console.Write($" {writeArray[i, j, k]}({i},{j},{k})");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void FillArrayNumbers(int[] fillArray)
{
    for (int i = 0; i < fillArray.Length; i++)
    {
        fillArray[i] = min;
        min++;
    }
}

void writeArray(int[] wrireArray)
{
    for (int i = 0; i < wrireArray.Length; i++)
    {
        Console.Write(wrireArray[i] + " ");
    }
    Console.WriteLine();
}

int[] Shuffle(int[] shuffleArray)
{
    for (int i = 0; i < shuffleArray.Length; i++)
    {
        int randIndex = rand.Next(0, shuffleArray.Length);
        int temp = shuffleArray[i];
        shuffleArray[i] = shuffleArray[randIndex];
        shuffleArray[randIndex] = temp;
    }
    return shuffleArray;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}