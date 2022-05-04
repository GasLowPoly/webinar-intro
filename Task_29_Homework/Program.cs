// Напишите программу, которая задает массив из 8 случайных чисел и выводит отсортированный по модулю массив


int[] array = new int[8];

int lenght = array.Length;
for (int i = 0; i < lenght; i++)
{
    array[i] = new Random().Next(-100, 101);
    Console.Write(array[i] + ", ");
}


Console.WriteLine(string.Empty);
Console.WriteLine(string.Empty);

for (int i = 0; i < array.Length - 1; i++)
{
    int minPosition = i;

    for (int j = i + 1; j < array.Length; j++)
    {
        if (Math.Abs(array[j]) < Math.Abs(array[minPosition])) minPosition = j;
    }

    int temp = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temp;
}


for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + ", ");
}
