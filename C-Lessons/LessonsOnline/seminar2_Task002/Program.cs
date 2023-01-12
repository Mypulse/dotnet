/* Написать программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа.
78 -> 8
12 -> 2
85 -> 8
*/

int GetMaxDigit(int num)
{
    int maxDigit;
    int second_decimal_place = num % 10;
    int first_decimal_place = num / 10;

    if(second_decimal_place >= first_decimal_place)
    {
        maxDigit = second_decimal_place;
    }
    else
    {
        maxDigit = first_decimal_place;
    }
    return maxDigit;
}

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка [10, 99] {number}");

int result = GetMaxDigit(number);
System.Console.WriteLine($"Максимальное цифра {number} -> {result}");
