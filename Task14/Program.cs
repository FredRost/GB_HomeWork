Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool checkNumber = CheckNumber(number);
bool CheckNumber(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}
Console.WriteLine(checkNumber ? "Да" : "Нет");