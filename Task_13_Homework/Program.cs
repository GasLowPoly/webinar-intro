// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.Clear();
Console.WriteLine("Set any number");
try
{
    string numbers = Console.ReadLine();
    int length = numbers.Length;
    Convert.ToInt32(numbers);
    if (length < 3)
    {
        Console.WriteLine("There is no 3rd digit");

    }
    else
    {
        Console.WriteLine("Third digit is " + numbers[2]);
    }
}

catch(Exception ex)
{
    Console.WriteLine("Wrong input, try to set numbers only");
}