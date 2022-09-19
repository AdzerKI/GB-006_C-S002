/*
16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет*/

Console.Write("Ведите первое число:");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите второе число:");
int y = Convert.ToInt32(Console.ReadLine());

if (x ==  y * y || y == x * x)
{
    Console.Write("да");
}
else
{
    Console.Write("нет");
}