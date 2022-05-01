// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// а если нет, то выводит остаток от деления

void MultipleCheck(int current_number1, int current_number2)
{
    if (current_number1 % current_number2 == 0)
    {
        Console.WriteLine("B is multiple of A");
    }
    else
    {
        Console.WriteLine("B is NOT multiple of A. Remainder of the division A/B is " + (current_number1 % current_number2));
    }
}


Console.WriteLine("Set number A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Set number B");
int b = Convert.ToInt32(Console.ReadLine());

MultipleCheck(a, b);
