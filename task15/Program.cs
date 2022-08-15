// Задача 15.

Console.WriteLine("Введите число дня недели");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 6 || number == 7)

{
    Console.WriteLine ("Это выходной день");
}

else if (number < 1 || number > 7)


{
    Console.WriteLine ("Такого дня недели не существует");
}
else Console.WriteLine ("Это будний день");