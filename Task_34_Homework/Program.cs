// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// Прим: [345, 897, 568, 234] -> 2

Random rand = new Random();
int[] array = new int[rand.Next(3, 11)];
int length = array.Length;
Console.Write("[");
for (int i = 0; i < length; i++)
{
    array[i] = rand.Next(100, 1000);
    Console.Write($"{array[i]} ");
}
Console.Write("] ");
int count = 0;
for (int i = 0; i < length; i++)
{
    if (array[i] % 2 == 0) count++;
}

Console.WriteLine($"-> {count}");