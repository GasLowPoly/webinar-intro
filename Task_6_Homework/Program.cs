// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.WriteLine("Even or uneven? Set number for check!");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 != 0) Console.Write(number + " is uneven number");
else
{
    Console.Write(number + " is even number");
}

