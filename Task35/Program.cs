/*
Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int size = 123;
int[] numbers = new int[size];
int min = 10;
int max = 99;
int count = 0;
FillArrayRandomNumbers(numbers, 0, 130);
WriteArray(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] < min || numbers[i] > max)
        continue;
    
    count++;
}
Console.WriteLine(count);


void FillArrayRandomNumbers(int[] array, int min = 1, int max = 9)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}