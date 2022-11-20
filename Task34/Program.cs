// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

int size = 10;
int min = 100;
int max = 1000;
int count = 0;
int[] numbers = new int[size];

numbers = ReadArray(numbers);
numbers = WriteArray(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    if (EvenNumberCheck(numbers[i]))
    {
        count++;
    }
}
Console.WriteLine($"Количество четных чисел в массиве {count}");


int[] ReadArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

int [] WriteArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
    
}

bool EvenNumberCheck(int number)
{
    if((number % 2) == 0)
    {
        return true;
    }
    return false;
}