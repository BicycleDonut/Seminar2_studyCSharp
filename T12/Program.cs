﻿// Напишите программу, которая будет принемать на вход два числа и выводить,
// является ли второе число, кратным первому. Если число 2 не кратно 1 то  
// программа выводит остаток от деления
// 34,5 не кратно, остаток 4
// 16,4 кратно

Console.WriteLine("Введите первое число:  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:  ");
int b = Convert.ToInt32(Console.ReadLine());
if (a % b == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Не кратно,остаток{a % b}");
}