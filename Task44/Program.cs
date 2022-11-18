// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// int a = 0;
// int b = 1;
// int c = 0;
// int i = 0;
// int num = ReadInt("Введите номер элемента: ");
// int ReadInt(string text)
// {
//     Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }
// if (num == 1)
//     Console.Write($"{a} ");
// else if (num == 2)
//     Console.Write($"{a} {b} ");
// else if (num < 1)
//     Console.Write("Число должно быть больше 0");
// else if (num > 2)
// {
//     Console.Write($"{a} {b} ");
//     while (i < num-2)
//     {    
//     c = a + b;
//     a = b;
//     b = c;
//     Console.Write($"{c} ");
//     i++;
//     }
// }


// int count = ReadInt("Введите количество членов: ");  
// int first = 0;
// int second = 1;

// if(count > 0)
// {
//     Console.Write(first + " ");
// }

// if(count > 1)
// {
//     Console.Write(second + " ");
// }

// for(int i = 2; i < count; i++)
// {
//     int next = first + second;
//     first = second;
//     second = next;
//     Console.Write(next + " ");
// }

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

int count = ReadInt("Введите количество членов: ");  
int[] fibbonachi = new int[count];
if(count > 0)
{
    fibbonachi[0] = 0;
}

if(count > 1)
{
    fibbonachi[1] = 1;
}

for(int i = 2; i < fibbonachi.Length; i++)
{
    fibbonachi[i] = fibbonachi[i - 1] + fibbonachi[i - 2];
}

for(int i = 0; i < fibbonachi.Length; i++)
{
    Console.Write(fibbonachi[i] + " ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}