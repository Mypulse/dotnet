//Работа с функцими

int GetSquare(int number) // объявлять функции лучше сверху 
{
    return number * number;
}

int number = 7;
int square = GetSquare(number);
Console.WriteLine(square);
