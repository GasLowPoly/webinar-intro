// Напишите программу, которая принимает на вход число (А) и выдает произведение чисел от 1 до А

int number = Convert.ToInt32(Console.ReadLine());
int Factorial(int x)
{
    int result = 1;
    for (int i = 1; i <= x; i++)
    {
        result *= i;
    }
    return result;
}
Console.WriteLine(Factorial(number));

