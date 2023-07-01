// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пять символов: ");
string symbols = Console.ReadLine();
int quant = symbols.Length;

if (quant == 5)
{
    if (symbols[0] == symbols[4] && symbols[1] == symbols[3])
    {
        Console.Write($"{symbols} - это палиндром");
    }
    else
    {
        Console.Write($"{symbols} - это НЕ палиндром");
    }
}
else
{
    Console.Write($"{symbols} - не является пятизначным");
}