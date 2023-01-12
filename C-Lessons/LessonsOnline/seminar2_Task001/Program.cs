/* Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8
*/

Console.WriteLine("Эта программа принимает на вход трехзначное число и на выходе показывает послднюю цифру");
Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine()!);

int get_last_digit(int number)
{
    return number % 10;
}

if (number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ввели не корректное число!");
}
else
{
    Console.WriteLine($"Последняя цифра числа {number} - {get_last_digit(number)}");
}



