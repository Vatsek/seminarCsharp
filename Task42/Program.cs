// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// int number = ReadInt("Введите десятичное число: ");  
// string result = String.Empty;

// while(number > 0)
// {
//     result = number % 2 + result;
//     number /= 2;
// }
// Console.WriteLine(result);

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

//второе решение и правильное: 

int number = ReadInt("Введите десятичное число: ");  
int tempNumber = number;
int size = 0;
int[] result;

while(tempNumber > 0)
{
    size++;
    tempNumber /= 2;
}
result = new int[size];
for (int i = 0; i < result.Length; i++)
{
    result[result.Length - 1 - i] = number % 2;
    number /= 2;
}

for (int i = 0; i < result.Length; i++)
{
    Console.Write(result[i] + " ");
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}