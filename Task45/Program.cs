// Задача 45: Напишите программу, которая будет создавать копию заданного массива с
// помощью поэлементного копирования.

int[] numbers = {2, 5, 15, 2, 4, 16};
int[] numbersTest = CopyArray(numbers);

WriteArray(numbers);
WriteArray(numbersTest);

int[] CopyArray(int[] array)
{
    int[] copyArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {   
        copyArray[i] = array[i];
    }
    return copyArray;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
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
