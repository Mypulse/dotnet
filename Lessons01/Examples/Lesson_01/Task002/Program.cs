int a = 79;
int b = 67;
int max;
int min;

if (a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}

Console.WriteLine("Максимальное значение " + max);
Console.WriteLine("Минимальное значение " + min);