// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// Прим:
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Random rand = new Random();
int[] array = new int[rand.Next(3, 11)];
int length = array.Length;
Console.Write("[");
for (int i = 0; i < length; i++)
{
    array[i] = rand.Next(11);
    Console.Write($"{array[i]} ");
}
Console.Write("] ");


int summ = 0;
for (int i = 0; i < length; i += 2)
{
    summ += array[i];
}

Console.WriteLine($"Uneven summ is {summ}");