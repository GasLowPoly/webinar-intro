/* напишите программу, которая принимает на вход координаты точки (Х, Y)
причем X!=0 и Y!=0 и выдает номер четверти плоскости, в которой находится эта точка
2 || 1
======
3 || 4
*/
Console.WriteLine("Set X,Y coordinates:");
Console.Write("X = ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y = ");
int y = Convert.ToInt32(Console.ReadLine());

int CheckPlane(int coordinate_x, int coordinate_y)
{
    int plane = 0;

    if (coordinate_x > 0) //если Х > 0
    {
        if (coordinate_y > 0) plane = 1;
        else plane = 4;
    }
    if (coordinate_x < 0)
    {
        if (coordinate_y > 0) plane = 2;
        else plane = 3;
    }

    return plane;
}

if (CheckPlane(x, y) != 0)
{
    Console.WriteLine("Plane quarter is " + CheckPlane(x, y));
    Console.WriteLine("  y");
    Console.WriteLine("2 | 1");
    Console.WriteLine("——+—— x");
    Console.WriteLine("3 | 4");
}
else Console.WriteLine("Your point is on the axis (X,Y)");
