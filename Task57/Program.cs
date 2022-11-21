// Задача 57: Составить частотный словарь элементов двумерного массива.
//  Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.

// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6

// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза


int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
FillMatrix(numbers);
PrintMatrix(numbers);
SortArray(numbers);
PrintMatrix(numbers);
int[,] dictionary = FrequencyDictionary(numbers);
for (int i = 0; i < dictionary.GetLength(0); i++)
{
    Console.WriteLine($"{dictionary[i, 0]} встречается {dictionary[i, 1]}");
}

int[,] FrequencyDictionary(int[,] matrix)
{
    int size = CalculateCountNumbers(matrix);
    int[,] dictionary = new int[size, 2];
    int dictionaryIndex = 0;
    dictionary[dictionaryIndex, 0] = matrix[0, 0];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if (dictionary[dictionaryIndex, 0] == matrix[i, j])
                dictionary[dictionaryIndex, 1]++;
            else
            {
                dictionaryIndex++;
                dictionary[dictionaryIndex, 0] = matrix[i, j];
                dictionary[dictionaryIndex, 1] = 1;
            }
        }
    }
    return dictionary;
}

int CalculateCountNumbers(int[,] sortMatrix)
{
    int countNumbers = 1;
    int tempNumber = sortMatrix[0, 0];
    for(int i = 0; i < sortMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < sortMatrix.GetLength(1); j++)
        {
            if(tempNumber != sortMatrix[i, j])
            {
                tempNumber = sortMatrix[i, j];
                countNumbers++;
            }
        }
    }

    return countNumbers;
}

void SortArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int a = 0; a < matrix.GetLength(0); a++)
            {
                for (int b = 0; b < matrix.GetLength(1); b++)
                {
                    if (matrix[a, b] < matrix[i, j])
                    {
                        int temp = matrix[i, j];
                        matrix[i, j] = matrix[a, b];
                        matrix[a, b] = temp;
                    }
                }
            }
        }
    } 
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(0, 10);
        }
    }
}

int ReadInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}








/*
решение в группе!


int rows = 5;
int columns = 5;
int[,] numbers = new int[rows,columns]; // массив
int[] sumTotalColumn = new int[columns]; // итоги
int[] averColumn = new int[columns]; // среднее по колонкам
int minR = 1; int maxR = 30; // для random

int min = 0;
int max = 0;

FillRandomArray(numbers);
Print2DArray(numbers);
FindMinMax();

for(int i = min; i <=max; i++)
{
    FindCount(i);
}

void FindMinMax()
{
    for(int row = 0; row < numbers.GetLength(0); row++)
    {
        for(int col = 0; col < numbers.GetLength(1); col++)
        {
            if(numbers[row,col] < min)
                min = numbers[row,col];
            if(numbers[row,col] > max)
                max = numbers[row,col];                
        }
    }
}

void FindCount(int num)
{
    int count = 0;
    for(int row = 0; row < numbers.GetLength(0); row++)
    {
        for(int col = 0; col < numbers.GetLength(1); col++)
        {
            if(num == numbers[row,col])
                count++;
        }
    }
    if (count > 0)
        Console.WriteLine($"{num} встречается {count} раз");
}

void FillRandomArray(int[,] array)
{
    Random rnd = new Random();
    for(int row = 0; row < array.GetLength(0); row++)
    {
        for(int col = 0; col < array.GetLength(1); col++)
        {
            array[row,col] = rnd.Next(minR,maxR);
        }
    }
}

void Print2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {            
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

*/


/*
второе решение
int[,] array = {{1, 2, 3},{4, 6, 1},{2, 1, 6}};

int max = array[0,0];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i,j] > max)
        {
            max = array[i,j];
        }
    }
}
int[] count = new int[max+1];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        
     count[array[i,j]]++;
        
    }
}
for (int j = 0; j < max+1; j++)
{
    if (count[j]!=0)
Console.WriteLine($"количество {j} - {count[j]}");
}

*/


/*
второй вариант

int rows = 5;
int columns = 5;
int[,] numbers = new int[rows,columns]; // массив
int[] sumTotalColumn = new int[columns]; // итоги
int[] averColumn = new int[columns]; // среднее по колонкам
int minR = 1; int maxR = 30; // для random
//int[] dict = new int[rows*columns];
int min = 0;
int max = 0;

FillRandomArray(numbers);
Print2DArray(numbers);
FindMinMax();

for(int i = min; i <=max; i++)
{
    FindCount(i);
}

void FindMinMax()
{
    for(int row = 0; row < numbers.GetLength(0); row++)
    {
        for(int col = 0; col < numbers.GetLength(1); col++)
        {
            if(numbers[row,col] < min)
                min = numbers[row,col];
            if(numbers[row,col] > max)
                max = numbers[row,col];                
        }
    }
}
void FindCount(int num)
{
    int count = 0;
    for(int row = 0; row < numbers.GetLength(0); row++)
    {
        for(int col = 0; col < numbers.GetLength(1); col++)
        {
            if(num == numbers[row,col])
                count++;
        }
    }
    if (count > 0)
        Console.WriteLine($"{num} встречается {count} раз");
}

void FillRandomArray(int[,] array)
{
    Random rnd = new Random();
    for(int row = 0; row < array.GetLength(0); row++)
    {
        for(int col = 0; col < array.GetLength(1); col++)
        {
            array[row,col] = rnd.Next(minR,maxR);
        }
    }
}

void Print2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {            
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

*/