// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве

Random rand = new Random();
int[] array = new int[rand.Next(2, 30)];

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
int FindValue(int[] arrayName, int findWhat)
{
    int length = arrayName.Length;
    int result = 0;
    for (int i = 0; i < length; i++)
    {
        if (arrayName[i] == findWhat)
        {
            result = 1+i;
            break;
        }
    }
    return result;
}

FillArrayRandomly(array, 0, 10);
Console.WriteLine(string.Empty);
Console.WriteLine("Which value are you looking for?");
string answer = Console.ReadLine();

try
{
int value = Convert.ToInt32(answer);
int result = FindValue(array,value);
if (result>0) Console.WriteLine($"Value {value} have index [{result-1}] in this array");
else Console.WriteLine($"There is no {value} in this array");
}

catch 
{
    Console.WriteLine($"There is no '{answer}' in this array");
}