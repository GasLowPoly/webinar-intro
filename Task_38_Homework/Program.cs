// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Прим: [3 7 22 2 78] -> 76

Random rand = new Random();
int[] array = new int[rand.Next(3, 11)];
int length = array.Length;
int max = 0;
int min = 100;

for (int i = 0; i < length; i++)
{
    array[i] = rand.Next(101);
    Console.Write(array[i] + " ");
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];

}

Console.WriteLine(string.Empty);
Console.WriteLine($"in this array min is {min}, max is {max}, difference is {max-min}");

// for (int j = i + 1; j < length; j++)