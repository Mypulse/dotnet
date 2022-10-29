int a = 5;
int b = - 7;
int max = 0;
int min = 0;

if( a > b )
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
