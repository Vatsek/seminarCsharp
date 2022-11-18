/*
Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.Write("Введите число, которому будет равен размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[size];
int index = 0;

while (index < numbers.Length)
{
    Console.WriteLine("Введите элемент массива:");
    numbers[index] = Convert.ToInt32(Console.ReadLine());
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