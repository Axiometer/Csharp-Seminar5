// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве

int GetValue(string msg)
{
    System.Console.Write(msg);
    string? v = Console.ReadLine();
    return Convert.ToInt32(v);
}

int[] SetArray(int length, int min, int max)
{
    int[] tempArr = new int[length];
    for (int i = 0; i < length; i++)
        tempArr[i] = new Random().Next(min, max);
    
    return tempArr;
}

void WriteArrayToConsole(int[] intArray)
{
    for (int i = 0; i < intArray.Length; i++)
    {
        Console.Write(intArray[i]);
        if (i != intArray.Length-1)
            Console.Write(", ");
    }
}

int length = GetValue("Введите количество элементов массива: ");
// int length = 8;
int min = 100;
int max = 999;

int[] Random3DigitsArray = SetArray(length, min, max);

Console.Write("Исходный массив: ");
WriteArrayToConsole(Random3DigitsArray);

int evenNumbers = 0;

for (int i = 0; i < Random3DigitsArray.Length; i++)
{
    if (Random3DigitsArray[i] % 2 == 0)
        evenNumbers++;
}

Console.Write("\nКоличество четных чисел в нем: " + evenNumbers);