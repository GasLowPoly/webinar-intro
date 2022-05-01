// Напишите программу, которая принимает на вход два числа и проверяет, является ли второе число квадратом первого

Console.WriteLine("Set 1st number for check");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Set 2nd number for check");
int number2 = Convert.ToInt32(Console.ReadLine());

void CheckSqr(int a, int b)
{
    if (a == b * b || b == a * a)
    {
        Console.WriteLine("one of these numbers is square of another ");
    }
    else
    {
        Console.WriteLine("No squares here");
    }
}

CheckSqr(number1, number2);