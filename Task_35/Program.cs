// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]
int[] array = new int[123];
FillArrayRandomly(array, 0, 150);
Console.WriteLine(string.Empty);
Console.WriteLine(CountBetween(array,10,99));


int CountBetween(int[] arrayName, int minValue, int maxValue)
{
    int length = arrayName.Length;
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if ((arrayName[i] <= maxValue) && (arrayName[i] >= minValue)) count++;
    }
    return count;
}

void FillArrayRandomly(int[] arrayName, int minValue, int maxValue)
{
    int length = arrayName.Length;
    Random randFill = new Random();
    for (int i = 0; i < length; i++)
    {
        arrayName[i] = randFill.Next(minValue, maxValue + 1);
        Console.Write(arrayName[i] + " ");
    }
}