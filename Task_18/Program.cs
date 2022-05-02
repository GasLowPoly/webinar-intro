// Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (Х и Y)

int[] coordinates = new int[2]; // создаем массив

int[] RndCoordinates(int[] collection) // заполняем массив координат рандомными значениям
{
    collection[0] = new Random().Next(1, 100);
    collection[1] = new Random().Next(1, 100);
    return collection;
}

Console.Write("Set plane quarter: ");
int quarter = Convert.ToInt32(Console.ReadLine()); //водим номер четверти 

switch (quarter) // выбираем действие в зависимости от введенной четверти
{
    case 1: // для 1 четверти х>0, у>0
        Console.WriteLine("1st plane have this points:");
        for (int i = 0; i < 10; i++)
        {
            RndCoordinates(coordinates);
            Console.WriteLine($"({coordinates[0]};{coordinates[1]})");
        }
        break;
    case 2: // для 2 четверти х<0 y>0
        Console.WriteLine("2nd plane have this points:");
        for (int i = 0; i < 10; i++)
        {
            RndCoordinates(coordinates);
            Console.WriteLine($"({(coordinates[0]) * -1};{coordinates[1]})");
        }
        break;
    case 3: // для 3 четверти x<0, y<0
        Console.WriteLine("3rd plane have this points:");
        for (int i = 0; i < 10; i++)
        {
            RndCoordinates(coordinates);
            Console.WriteLine($"({(coordinates[0]) * -1};{(coordinates[1]) * -1})");
        }
        break;
    case 4: // для 4 четверти x>0, y<0
        Console.WriteLine("4th plane have this points:");
        for (int i = 0; i < 10; i++)
        {
            RndCoordinates(coordinates);
            Console.WriteLine($"({coordinates[0]};{(coordinates[1]) * -1})");
        }
        break;
    default:
        Console.WriteLine("We have only 4 quarter in plane. choose it wisely from 1 to 4");
        break;
}
