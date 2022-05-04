// Напишите ЦИКЛ, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В

Console.WriteLine("Set A = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Set B = ");
int b = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 0; i < b; i++)
{
    result *= a;
}
Console.WriteLine($"A^B = {result}");