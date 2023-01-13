/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int GetThirdDigit(int number)
{
    int ThirdDigit = number % 10;
    return ThirdDigit;
}

int number;
int result;

Console.WriteLine("Введите трехзначное число: ");
number = int.Parse(Console.ReadLine()!);

if (number <= 99)
{
    Console.WriteLine("Нет третьей цифры");
    return;
}
if(number >= 1000)
    {
        Console.WriteLine("Введено не верное значение");
        return;
    }
else
{
    result = GetThirdDigit(number);
}

Console.WriteLine($"Третье цифра числа {number} -> {result}");
