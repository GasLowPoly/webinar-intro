// Напишите программу, которая принимает на вход трёхзначное число и на выходе выводит перевернутое число
// 456 -> 654
// 782 -> 287

Console.WriteLine("Type anytheng for reverse");
string line = Console.ReadLine();
ReverseLine(line);

void ReverseLine(string strng)
{
    int length = line.Length;
    int i = length - 1;
    while (i != -1)
    {
        Console.Write(line[i]);
        i--;
    }
}
