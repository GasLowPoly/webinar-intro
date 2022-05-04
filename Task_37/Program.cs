// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новый массив

Random rand = new Random();

int[] array = new int[rand.Next(0, 16)];
int length = array.Length;

for (int i = 0; i < length; i++)
{
    array[i] = rand.Next(0, 10);
    Console.Write(array[i] + " ");
}
int newlenght = length / 2;
int[] secondarray = new int[newlenght];

Console.WriteLine(string.Empty);

for (int i = 0; i < newlenght; i++)
{
    int mult = array[i] * array[length - i - 1];
    secondarray[i] = mult;
    Console.Write(secondarray[i] + " ");
}