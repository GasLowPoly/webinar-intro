// Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N
// Прим: 3 -> 1, 4, 9

int n = Convert.ToInt32(Console.ReadLine());
Console.Write(n+" -> 1");

for (int i = 2; i <= n; ++i)
{
    Console.Write($", {Math.Pow(i,3)}");
}