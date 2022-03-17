// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.WriteLine("Set first number");
int a = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("Set second number");
int b = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("Set third number");
int c = Convert.ToInt32(Console.ReadLine());
Console.Clear();

int max = a;
if (max < b) max = b;
if (max < c) max = c;

Console.WriteLine(max + " is biggest number");