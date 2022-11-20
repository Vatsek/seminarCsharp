/*
Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int size = ReadInt("Введите число, которому будет равен размер массива: ");

int[] numbers = new int[size];
int index = 0;

while (index < numbers.Length)
{
    numbers[index] = ReadInt($"Введите {index} элемент массива:");
    index++;
}

Console.Write($" Получившийся массив: ");
PrintArray(numbers);




void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}