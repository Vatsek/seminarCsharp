/*
Задача 32: Напишите программу замена элементов массива: положительные элементы замените 
на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

int size = ReadInt("Введтие размер массива: ");
int[] numbers = new int[size];
FillArrayRundomNumbers(numbers, -10, 10);
WriteArray(numbers);

for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = -numbers[i];
}
WriteArray(numbers);

void FillArrayRundomNumbers(int[] array, int min = 1, int max = 9)
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
    return Convert.ToInt32(Console.ReadLine());
}