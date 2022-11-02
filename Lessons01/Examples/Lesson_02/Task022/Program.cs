double GetValue(string text)
{
    Console.Write(text + ": "); // Добавили пробел
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}

void Print(double x1, double y1, double x2, double y2, double res)
{
    // A(1, 2); B(4, 5) = 6
    /*string output = "|A(" + ax + ", " + ay + "); B(" + 
                             bx + ", " + by + ")| = " + 
                             //result;
                             Math.Round(result, 2);
    */
    double r = Math.Round(res, 2); // сокращаем ответ до 2 знаков после запятой
    string output = $"|A({x1}, {y2}); B({x2}, {y2}) = {r}";
    Console.WriteLine(output);
}

double GetDistance(double ax, double ay, double bx, double by)
{
    double x = (ax - bx) * (ax - bx);
    double y = Math.Pow(ay - by, 2);
    double result = Math.Sqrt(y + x); // Извлечение из корня
    return result;
}

double ax = GetValue("ax");
double ay = GetValue("ay");
double bx = GetValue("bx");
double by = GetValue("by");

double dis = GetDistance(ax, ay, bx, by);
Print(ax, ay, bx, by, dis);

