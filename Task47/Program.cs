// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


int m = ReadInt("Введите количество строк в массиве: ");

if(NegativeZeroNumberCheck(m))
    return;

int n = ReadInt("Введите количество столбцов в массиве: ");

if(NegativeZeroNumberCheck(n))
    return;

double[,] numbers = new double[m, n];

int from = -100;
int to = 100;

Fill2DArray(numbers, from, to);
Write2DArray(numbers);

void Fill2DArray(double[,] array, int numberFrom, int numberTo)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(RandFromTo(numberFrom, numberTo), 2);
        }
    }
}

void Write2DArray(double[,] printArray)
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

int ReadInt(string message)
{
    Console.Write($"{message} ");
    return Convert.ToInt32(Console.ReadLine());
}

bool NegativeZeroNumberCheck(int Inputnumber)
{
    bool result = Inputnumber <= 0;
    if(result == true)
        Console.WriteLine("Размер должен быть больше нуля");
    return result;
}

double RandFromTo(int from, int to)
        {
            Random rand = new Random();
            double d = rand.NextDouble()*(to - from) + from;
            return d;
        }