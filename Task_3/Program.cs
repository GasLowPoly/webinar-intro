// Напишите программу, которая будет выдfвать название дня недели по заданному номеру.



// Решение через switch
Console.Clear();
Console.WriteLine("Choose number of the day in week");
int day = Convert.ToInt32(Console.ReadLine());
switch (day)
{

    case 1:
        Console.WriteLine("1st day called Monday");
        break;

    case 2:
        Console.WriteLine("2nd day called Tuesday");
        break;

    case 3:
        Console.WriteLine("3rd day called Wednesday");
        break;

    case 4:
        Console.WriteLine("4th day called Thursday");
        break;

    case 5:
        Console.WriteLine("5th day called Friday");
        break;

    case 6:
        Console.WriteLine("6th day called Saturday");
        break;

    case 7:
        Console.WriteLine("7th day called Sunday");
        break;

    default:
        Console.WriteLine("We have only 7 days in week. You should choose correct number from 1 to 7");
        break;
}

// Решение через массив string
// string[] days = ("Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(days[num - 1]);