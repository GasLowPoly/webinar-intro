// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке

int[] array = new int[8];

void PrintArray(int[] anyArray)
{
    int count = anyArray.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write(anyArray[i]);
    }
}


void Radom1(int[] anyArray)
{
    int count = anyArray.Length;
    for (int i = 0; i < count; i++)
    {
        anyArray[i]=new Random().Next(0,2);
    }
}

PrintArray(array);
Console.WriteLine();
Radom1(array);
PrintArray(array);