// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = ReadInt("Введите размер массива: ");

if (size <= 0)
{
    Console.WriteLine("Размер массива должен быть больше нуля");
    return;
}
int[] numbers = new int[size];


Console.WriteLine("Определим диапазон чисел, какими Вы хотите заполнить массив:");

int min = ReadInt("Введите min: ");
int max = ReadInt("Введите max: ");

if (min > max)
{
    Console.WriteLine("Невозможно определить диапозон чисел. Max должен быть больше Min");
    return;
}
numbers = ReadArray(numbers);

Console.Write("Получившийся массив: ");
WriteArray(numbers);

int sum = 0;

for (int i = 1; i < numbers.Length; i += 2)
{
    sum += numbers[i];
}
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях массива: {sum}");


int ReadInt(string message)
{
    Console.Write(message);

    return Convert.ToInt32(Console.ReadLine());
}


int[] ReadArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}


int[] WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();

    return array;
}