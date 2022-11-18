// Задайте массив из 12 элементов, который заполнен случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

int size = 12;
int min = -9;
int max = 9;
int[] numbers = new int[size];
int positiveSum = 0;
int negativeSum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(min, max + 1);
}
WriteArray(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] < 0)
        negativeSum += numbers[i];
    else   
        positiveSum += numbers[i];
}
Console.WriteLine($"Положительная сумма = {positiveSum}, отрицательная сумма = {negativeSum}");

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

