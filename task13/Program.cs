﻿// Задача 13.

Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberText = Convert.ToString(Number);
if (NumberText.Length > 2) 
{
    Console.WriteLine (NumberText[2]);
}
else 
{
    Console.WriteLine ("третьей цифры нет");
}