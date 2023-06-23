﻿﻿// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void PrintReversecheck(int number)
{
if (number / 10000 == number % 10 && number / 1000 % 10 == number % 100 / 10)
{
    Console.WriteLine("Данное число является палиндромом");
}
else
{  
    Console.WriteLine("Данное число не является палиндромом");
}
}

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

if (number < 10000 || number > 99999)
{
    Console.WriteLine("Это не пятизначное число!");
    return;
}
PrintReversecheck(number);
