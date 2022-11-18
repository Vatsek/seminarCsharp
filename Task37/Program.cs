/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int[] numbers = new int[5];
int lengthNewArray = 0;
Random rand = new Random();

FillArray(numbers);
WriteArray(numbers);

int count = numbers.Length % 2;

if (count > 0)
{
    lengthNewArray = numbers.Length / 2 + 1;
}
else
    lengthNewArray = numbers.Length / 2;

int[] numbers2 = new int[lengthNewArray];
count = lengthNewArray;
Console.WriteLine(count);

WriteArray(numbers2);


if (lengthNewArray / 2 == 0)
{
    for (int i = 0; i < lengthNewArray; i++)
    {
        numbers2[i] = numbers[i] * numbers[numbers.Length - 1 - i];
    }
}
else
{
    for (int i = 0; i < lengthNewArray - 1; i++)
    {
        numbers2[i] = numbers[i] * numbers[numbers.Length - 1 - i];
    }
    numbers2[count/2 +1] = numbers[count -1];
}
WriteArray(numbers2);




int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(1, 10);
    }
    return array;
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}