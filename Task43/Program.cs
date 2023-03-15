double InputDouble(string message)
{
    System.Console.WriteLine(message);
    double value;
    bool isCorrect = double.TryParse(Console.ReadLine(), out value);

    /// или  if (int.TryParse(Console.ReadLine(), out value))
    if (isCorrect)
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}

void InstersetionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
    System.Console.WriteLine($"Точка пересечения {x},{y}");
}

double b1 = InputDouble("Введите b1");
double k1 = InputDouble("Введите k1");
double b2 = InputDouble("Введите b2");
double k2 = InputDouble("Введите k2");

InstersetionPoint(b1,k1,b2,k2);