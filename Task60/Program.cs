// Задача 60. ...Сформируйте трёхмерный массив из случайных неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int depth = RedInt("Введите глубину: ");
int rows = RedInt("Введите количество строк: ");
int columns = RedInt("Введите количество столбцов: ");
int[,,] numbers = new int[depth, rows, columns];
int maxNumbers = 90;
int[] randomNumbers = new int[maxNumbers];

if(numbers.Length > maxNumbers)
{
    Console.WriteLine("Неповторяющийся массив такого размера невозможен");
    return;
}
int value = 10;
for (int i = 0; i < randomNumbers.Length; i++)
{
    randomNumbers[i] = value++;   
}
for (int i = 0; i < randomNumbers.Length; i++)
{
    int randomIndex = new Random().Next(0, randomNumbers.Length);
    int temp = randomNumbers[randomIndex];
    randomNumbers[randomIndex] = randomNumbers[i];
    randomNumbers[i] = temp;
}

int randomNumberIndex = 0;
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        for (int k = 0; k < numbers.GetLength(2); k++)
        {
            numbers[i,j,k] = randomNumbers[randomNumberIndex++];
        }
    }
}


for (int i = 0; i < numbers.GetLength(2); i++)
{
    for (int j = 0; j < numbers.GetLength(0); j++)
    {
        for (int k = 0; k < numbers.GetLength(1); k++)
        {
            Console.Write($"({j},{k},{i}) {numbers[j,k,i]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int RedInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}