// Напишите программу, которая принимает на вход число и выдает количество цифр в числе

Console.WriteLine("Set any number");
string line =Console.ReadLine();
try
{
int number = Convert.ToInt32(line);
int numlenght = line.Length;
Console.WriteLine(numlenght);
}
catch
{
    Console.WriteLine("This is not number, try again");
}
