// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.Clear();
Console.WriteLine("Set number A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("A = " + a + ". Now set number B");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("A = " + a + ". B = " + b + ". Let's check squares");

if (b * b == a)
{
    Console.WriteLine("A is square of B");
}
else
{
    Console.WriteLine("A is not square of B.");
    Console.WriteLine("Let's check B...");
    if (a * a == b)
    {
        Console.WriteLine("B is square of A");
    }
    else
    {
        Console.WriteLine("B is not square of A.");
    }

}
