int number = new Random().Next(100, 999);
Console.WriteLine($"Случайное число: {number}");

int delSecondDigit = Result(number);
int Result(int num)

{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int result = firstDigit * 10 + thirdDigit;
    return result;
}

Console.WriteLine($"Результат: {delSecondDigit}");
