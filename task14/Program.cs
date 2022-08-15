// Задача 14. Напишите программу, которая принимает на вход число

Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA%7==0 && numberA%23==0)

{
Console.WriteLine("да");
}
 else 
 {
 Console.WriteLine("нет");
 }