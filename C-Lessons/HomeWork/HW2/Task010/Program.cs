/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int GetSecondDigit(int num)
{
    int second_Decimal_Digit = num % 100;
    int result = num / 10 % 10;
    return result;
}


int number;
int result;

Console.WriteLine("Введите трехзначное число: ");
number = Convert.ToInt32(Console.ReadLine()!);

if (number < 100 || number >= 1000)
    {
        Console.WriteLine("Вы ввели не верное значение!");
        return;
    }
    else
    {
        result = GetSecondDigit(number);
    }


Console.WriteLine($"Вторая цифра числа {number} -> {result}");

