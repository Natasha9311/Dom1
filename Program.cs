﻿/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/


/*Console.Write("Введите первое число: ");
int firstdNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());


int max = firstdNumber;

if (firstdNumber > secondNumber) max = firstdNumber;
if (secondNumber > firstdNumber) max = secondNumber;

Console.Write("max= ");
Console.WriteLine(max);
*/

/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/


/* Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if(b > max) max = b;
if(c > max) max = c;


Console.Write("max= ");
Console.WriteLine(max);
*/

/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

/* Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N % 2 == 1)
{
    Console.WriteLine(" Число " +  N + " является: нечетным");
}
else
{
    Console.WriteLine(" Число" +  N + " является: четным");
}
*/

/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

int number = 0;
int x = 1;
Console.WriteLine("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());
while (x < number)
{
    if(x % 2 == 0)
    {
        Console.WriteLine(x);
    }
    x++;
}