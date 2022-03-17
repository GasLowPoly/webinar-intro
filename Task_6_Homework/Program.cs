// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.WriteLine("Even or uneven? Set number for check!");
int N = Convert.ToInt32(Console.ReadLine());

if (N % 2 != 0) Console.Write(N + " is uneven number");
else
{
    Console.Write(N + " is even number");
}

