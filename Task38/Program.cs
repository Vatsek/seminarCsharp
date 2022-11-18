// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int size = 10;
int min = 10;
int max = 100;
int bitDepth = 100; //разрядность
Random rand = new Random();

double[] numbers = new double[size];

numbers = ReadArray(numbers, min, max);

Console.Write($"Массив случайных вещественных чисел: ");
WriteArray(numbers);

double minInArr = SearchMin(numbers);
double maxInArr = SearchMax(numbers);

Console.WriteLine($"Максимальное число в массиве: {maxInArr}");
Console.WriteLine($"Минимальное число в массиве: {minInArr}");

double differenceMinMax = maxInArr - minInArr;

Console.WriteLine($"Разница между максимальным и минимальным числом в массиве: {Math.Round(differenceMinMax, 2)}");



double SearchMin(double[] array)
{
    double numMin = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (numMin > array[i])
        {
            numMin = array[i];
        }
    }
    return numMin;
}

double SearchMax(double[] array)
{
    double numMax = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (numMax < array[i])
        {
            numMax = array[i];
        }
    }
    return numMax;
}


double RandDouble(int min, int max)
{
    double a = rand.Next(min, max);
    double b = rand.Next(min, max);
    double result = a + (b / bitDepth);
    return result;
}

double[] ReadArray(double[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = RandDouble(min, max);
    }
    return array;
}

double [] WriteArray(double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} |");
    }
    Console.WriteLine();
    return array;
}