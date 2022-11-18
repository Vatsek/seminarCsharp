/* 
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Введите числа");

string inputText = Console.ReadLine();

int sizeArrayNumbers = QuantityNumbers(inputText, ',');

int[] numbersArray = new int[sizeArrayNumbers];

numbersArray = FillArrayNumbersFromText(inputText, ',', numbersArray);

int negativeNumbers = NegativeNumberCount(numbersArray);

Console.WriteLine($"Количество введенных чисел больше нуля: {negativeNumbers}");



int[] FillArrayNumbersFromText(string inputText, char separator, int[] array)
{
    string stringNumber = string.Empty;
    int indexArray = 0;

    for (int i = 0; i < inputText.Length; i++)
    {
        if (inputText[i] != separator)
        {
            stringNumber += inputText[i];
        }
        else
        {
            array[indexArray++] = Convert.ToInt32(stringNumber);
            stringNumber = string.Empty;
        }
    }
    array[indexArray] = Convert.ToInt32(stringNumber);
    return array;
}


int QuantityNumbers(string text, char separator)
{
    int countNumbers = 1;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == separator)
            countNumbers++;
        
    }
    return countNumbers;
}


int NegativeNumberCount(int[] checkArray)
{
    int count = 0;
    for (int i = 0; i < checkArray.Length; i++)
    {
        if (checkArray[i] > 0)
            count++;
    }
    return count;
}
