// Напишите программу, которая принимает на вход число N и выдает таблицу квадратов чисел от 1 до N

int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; --n)
{
    string msg = "______";
    msg = n+"|"+Math.Pow(n,2);
    Console.WriteLine(msg);
}