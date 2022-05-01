// напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

void Multiple7and23(int current_number)
{
    if (current_number % 7 == 0)
    {
        Console.Write(current_number+" can be devided by 7");
        if (current_number % 23 == 0)
        {
            Console.Write(" and 23");
            
        }
        else
        {
            Console.Write(", but not 23");
        }
    }
    else
    {
        Console.Write(current_number+" can't be devided by 7");
        if (current_number % 23 == 0)
        {
            Console.Write(", but possible to devide "+current_number+" by 23");
        }
        else
        {
            Console.Write(" and 23");
        }
    }
}

Console.Clear();
Console.WriteLine("Set any number for check");
int number = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Multiple7and23(number);