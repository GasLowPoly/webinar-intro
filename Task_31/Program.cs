// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9]. 
// Найдите сумму отрицательных и положительных элементов массива
// Прим: [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] +: 29 |-: -20

//int[] array = {3,9,-8,1,0,-7,2,-1,8,-3,-1,6};
int[] array = new int[12];
int length = array.Length;
int negSumm = 0;
int posSumm = 0;

Random rand = new Random();
for (int i = 0; i < length; i++)
{
    array[i] = rand.Next(-9, 10);
    if (array[i] < 0) negSumm += array[i];
    else posSumm += array[i];
    Console.Write(array[i] + " ");
}
Console.WriteLine(string.Empty);
Console.WriteLine($"Summ of positive elements is {posSumm}");
Console.WriteLine($"Summ of positive elements is {negSumm}");