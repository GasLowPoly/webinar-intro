// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.WriteLine("Set any number");
int a = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("Set another number");
int b = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine(a+" ? "+ b +"...");

if (a > b) Console.WriteLine(a + " is highest number. " + b + " is lowest one");
if (b > a) Console.WriteLine(b + " is highest number. " + a + " is lowest one");
if (a == b) Console.WriteLine(a + " and " + b + " are the same numbers");
