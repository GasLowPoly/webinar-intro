// Напишите программу, которая выводит 10 случайных чисел из отрезка [10, 99] и показывае наибольшую цифру каждого числа


Random rand = new Random();
int number = rand.Next();

void FindMaxDigit(int current_number) // выбираем наибольшее число и выводим результат
{
    int t_place = current_number / 10; //десятки числа number
    int d_place = current_number % 10; //единицы числа number

    if (t_place > d_place)
    {
        Console.WriteLine(number + " -> " + t_place);
    }
    else 
    {
        Console.WriteLine(number + " -> " + d_place);
    }
}

for (int i=1;i<=10;i++) // цикл для перебора десяти цифр и вывода результатов через метод построчно
{
    number = rand.Next(10,100);
    FindMaxDigit(number);
}



