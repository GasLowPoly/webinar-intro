// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).


Console.WriteLine("Set number for square");
int number = Convert.ToInt32(Console.ReadLine());
int sq = number * number;
Console.WriteLine("Number is " + number + ". " + "Square is " + sq + ".");