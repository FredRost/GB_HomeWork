Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int multiplication = Multiplication(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {multiplication}");

int Multiplication (int num)
{
    int mult = 1;
    for (int i = 1; i <= num; i++)
    {
        mult = mult * i;
    }
    return mult;
}