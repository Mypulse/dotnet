/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3


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
    Console.WriteLine($"Наибольшее значение {max}");
    Console.WriteLine($"Наименьшее значение {min}");
}
else
{
    max = a; 
    min = b;
    Console.WriteLine($"Наибольшее значение {max}");
    Console.WriteLine($"Наименьшее значение {min}");
}
*/
//---------------------------------------------------------------------------------------------------------------------------------------------------------
/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22


int a, b, c;
int result;

Console.WriteLine("Введите первое число: ");
a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
c = int.Parse(Console.ReadLine()!);

if ((a > b) && (a > c))
{
    result = a; 
    Console.WriteLine($"Наибольшим числом является {a}");
}
if (b > c)
{
    result = b;
    Console.WriteLine($"Наибольшим числом является {b}");
}
else
{
    result = c;
    Console.WriteLine($"Наибольшим числом является {c}");
}
*/
/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет


int a;

Console.WriteLine("Введите число: ");
a = int.Parse(Console.ReadLine()!);

if (a % 2 == 0)
{
    Console.WriteLine($"Данное число является четным = {a}");
}
else
{
    Console.WriteLine($"Данное число не является четным = {a}");
}

*/

/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8


Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

for(int i = 0; i <= n; i++)
{
    if(i % 2 == 0)
    Console.WriteLine(i);
}
*/