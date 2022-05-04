// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот

Random rand = new Random();
int[] array = new int[rand.Next(2,11)];

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

void ValueReverse(int[] arrayName)
{
    int length = arrayName.Length;
    for (int i = 0; i < length; i++)
    {
        arrayName[i] *= -1;
        Console.Write(arrayName[i] + " ");
    }
}

FillArrayRandomly(array, -10,10);
Console.WriteLine(string.Empty);
ValueReverse(array);