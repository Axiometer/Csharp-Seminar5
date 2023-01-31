// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях

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
int min = -10;
int max = 100;

int[] RandomArray = SetArray(length, min, max);

Console.Write("Исходный массив: ");
WriteArrayToConsole(RandomArray);

int sum = 0;

Console.Write("\nЭлементы на нечетных позициях: ");
for (int i = 0; i < RandomArray.Length; i++)
{
    if (i % 2 != 0)
    {
        Console.Write(RandomArray[i] + " ");
        sum += RandomArray[i];
    }
}

Console.Write("\nСумма элементов, стоящих на нечетных позициях: " + sum);