// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе
// 452 -> 11; 82 -> 10

Console.WriteLine("Set number");
string line = Console.ReadLine();
try
{
    int number = Convert.ToInt32(line);
    int summ = 0;
    while (number > 0)
    {
        summ += number % 10;
        number /= 10;
    }
    Console.WriteLine($"Summ of all digits in your number ({line}) is {summ}");
}
catch
{
    Console.WriteLine("Invalid symbols, next time set a number");
}
