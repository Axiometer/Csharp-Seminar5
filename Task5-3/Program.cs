// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива

int GetValue(string msg)
{
    System.Console.Write(msg);
    string? v = Console.ReadLine();
    return Convert.ToInt32(v);
}

double[] SetArrayOfDouble(int length, int min, int max)
{
    double[] tempArr = new double[length];
    for (int i = 0; i < length; i++)
        tempArr[i] = new Random().Next(min, max) + Math.Round(new Random().NextDouble(), 2);
    
    return tempArr;
}

void WriteArrayToConsole(double[] intArray)
{
    for (int i = 0; i < intArray.Length; i++)
    {
        Console.Write(Math.Round(intArray[i], 2));
        if (i != intArray.Length-1)
            Console.Write("; ");
    }
}

int length = GetValue("Введите количество элементов массива: ");
// int length = 8;
int min = -10;
int max = 100;

double[] RandomArray = SetArrayOfDouble(length, min, max);

Console.Write("Исходный массив: ");
WriteArrayToConsole(RandomArray);

double maxinarray = min;
double mininarray = max;

for (int i = 0; i < RandomArray.Length; i++)
{
    if (RandomArray[i] < mininarray)
        mininarray = RandomArray[i];
    if (RandomArray[i] > maxinarray)
        maxinarray = RandomArray[i];
}

Console.Write("\nРазница между максимальным и минимальным элементов массива: " + Math.Round(maxinarray - mininarray,2));
