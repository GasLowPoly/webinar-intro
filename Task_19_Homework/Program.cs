// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// Прим: 12321 -> да | 12343 -> нет

// upd: перевел в общий случай для проверки на палинромность


string line = Console.ReadLine(); // берём строку из введенной консоли
line = line.ToLower();
int stringlength = line.Length; // запоминаем длину введённого
char[] collection = line.ToCharArray(); // создаем массив из char и запихиваем туда всё побуквенно из line
int count = -1;


for (int i = 0; i <= (stringlength / 2); i++) //перебираем и сравниваем первый и последний символы из массива
{
    if (collection[i] == collection[(stringlength - 1 - i)]) //если символы совпадают, то пополняем счетчик
    {
        count++;
    }
}

if (count == (stringlength / 2))
{
    Console.WriteLine($"{line} is a palindrome");
}
else
{
    Console.WriteLine($"{line} is NOT a palindrome");
}