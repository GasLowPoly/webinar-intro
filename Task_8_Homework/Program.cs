// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.WriteLine("Set number (N) to find all even numbers before N");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 0)
{
    Console.WriteLine("All even numbers before " + N + " are: ");
    if (N == 1) Console.WriteLine("There is no even numbers before 1");
    int i = 2;

    while (i < N)
    {
        Console.Write(i + " ");
        i = i+2;
    } 
}

else
{
    Console.WriteLine("N must be bigger than 0!");
}