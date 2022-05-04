// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А

int number = Convert.ToInt32(Console.ReadLine());
int AllSumm(int x)
{
    int summ = 0;
    for (int i = 1; i <= x; i++)
    {
        summ += i;
    }
    return summ;
}
Console.WriteLine(AllSumm(number));