/*Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.*/

Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int negativeN = -n;
int count = negativeN;

while (negativeN <= n)
{
    Console.Write(negativeN + " ");
    negativeN++;
}

