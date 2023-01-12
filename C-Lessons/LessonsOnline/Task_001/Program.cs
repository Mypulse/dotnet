/*
int number;
Console.WriteLine("Введите число: ");
number = int.Parse(Console.ReadLine()!);  // (!) Восклицательный знак нужен для того, что бы гарантировать, что значение в консоле не будет пустым.
// int.Parse(Console.ReadLine()!);        int.Parse позволяет преобразовать целочисленное значение в строку
// Convert.ToInt32(Console.ReadLine()!); второй вариант парсинга 
int squarOfNumber = number * number;
// System.Console.WriteLine("Квадрат числа " + " = " + squarOfNumber);
Console.WriteLine($"Квадрат числа {number} = {squarOfNumber} "); // Знак ($) Форматирует строку в кавычках 
*/
// ------------------------------------------------------------------------------------------------------------------------------------------------------
/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

int a;
int b;
int max;
int min;

Console.WriteLine("Введите первое число: ");
a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
b = int.Parse(Console.ReadLine()!);


if (a < b)
{
    max = b; 
    min = a;
}
else
{
    max = a; 
    min = b;
}

Console.WriteLine($"Наибольшее значение = {max}");




