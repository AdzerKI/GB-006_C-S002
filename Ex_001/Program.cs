/* 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8 
12-> 2 
85 -> 8
*/

int x = new Random().Next(10, 99);
Console.WriteLine(x);

int res_x = (x % 10);
int res_y = (x / 10);

if (res_x > res_y)
{
    Console.WriteLine(res_x);
}
else
{
    Console.WriteLine(res_y);
}






