double GetValue(string text)                                       // Обозначаем переменную
{
    Console.Write(text + ": ");                                    // Добавили пробел
    double value = Convert.ToDouble(Console.ReadLine());           // Конвертируем из string в int
    return value;                                                  // Возвращаем результат
}

void Print(double x1, double y1, double x2, double y2, double res) // Задаем переменные для метода  "double"
{
    // A(1, 2); B(4, 5) = 6                                        // То, как должен выглядеть вывод на печать.
    /*string output = "|A(" + ax + ", " + ay + "); B(" +           // -
                             bx + ", " + by + ")| = " +            // Определяем вывод на печать. Лучше испольщовать "АЛЬТЕРНАТИВНЫЙ СПОСОБ". (Строка 17) 
                             //result;                             // -
                             Math.Round(result, 2);                // -
    */
    double r = Math.Round(res, 2);                             // Сокращаем ответ до 2 знаков после запятой
    string output = $"A({x1}, {y2}); B({x2}, {y2}) = {r}";     // Определяем вывод на печать
    Console.WriteLine(output);                                 // Выводим на печать  
}

double GetDistance(double ax, double ay, double bx, double by) // Задаем переменные в методе "GetDistance"
{
    double x = (ax - bx) * (ax - bx);                          // С = (ax - bx)^ (Вычитаем координаты по X и возводим в квадрат)
    double y = Math.Pow(ay - by, 2);                           // С = (ay - by)^ (Вычитаем координаты по Y и возводим в квадрат) 
    double result = Math.Sqrt(y + x);                          // Извлечение из корня
    return result;
}

double ax = GetValue("ax");                                    // Пишем пользовательский код присваивая "double ax" значение переменной GetValue из 1-ой строки
double ay = GetValue("ay");                                    // Пишем пользовательский код присваивая "double ay" значение переменной GetValue из 1-ой строки
double bx = GetValue("bx");                                    // Пишем пользовательский код присваивая "double bx" значение переменной GetValue из 1-ой строки
double by = GetValue("by");                                    // Пишем пользовательский код присваивая "double by" значение переменной GetValue из 1-ой строки  

double dis = GetDistance(ax, ay, bx, by);                      // Создаем переменную "dis", которой присвоили "GetDistance" 
Print(ax, ay, bx, by, dis);                                    // Распечатываем результат включающий в себя расчет по координатам "dis"
