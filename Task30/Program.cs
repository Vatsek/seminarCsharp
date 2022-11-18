/*
Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами 
в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

// int[] numbers = new int[8];
// Random rnd = new Random();
// int i = 0;
// for (; i < numbers.Length-1; i++)
//     {   
//         numbers[i] = rnd.Next(0,2);
//         Console.Write(numbers[i] + ", ");
//     }
// Console.Write(numbers[i]);


int size = 8;
int[] numbers = new int[size];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(0, 2);
    Console.Write(numbers[i] + " ");
}