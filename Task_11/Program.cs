// Напишите подпрограмму, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
// пример: 456 -> 5 / 782 -> 8 / 918 -> 1


/* через выбор символа из строки
string number = Console.ReadLine();
while (number.Length !=3)
{
    Console.WriteLine("incorrect number");
    number = Console.ReadLine();
}
Console.WriteLine(number[1]);
*/

/* через 
Console.WriteLine("Введите трёхзначное число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine(a / 10 % 10);
*/

Console.WriteLine("Set 3-digit number");
int number = Convert.ToInt32(Console.ReadLine());

int SecondOf3(int SecondDigit) //метод выборки второй цифры в трехзначном числе
{
    SecondDigit = number / 10 % 10;
    return SecondDigit;
}

int CheckLength(int length) // проверка длины числа
{
    string num = Convert.ToString(number);
    length = num.Length;
    return length;
}

if (CheckLength(number) == 3)
{
    Console.WriteLine("Second digit is " + SecondOf3(number));
}
else
{
    Console.WriteLine("Wrong number");
}