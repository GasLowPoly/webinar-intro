// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет является ли этот день выходным

Console.Clear();

string[] week = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

Console.WriteLine("Set number of the day in week");
try
{
int day = Convert.ToInt32(Console.ReadLine());
Console.Clear();
if (day > 0 || day < 8)
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine($"{week[(day - 1)]} is weekend! Woohoo~!");
    }
    else
    {
        Console.WriteLine(week[(day - 1)] + " is working day. Sorry =(");
    }
}
}

catch
{
    Console.WriteLine("We have only 7 days in week, try to set number from 1 to 7");
}