Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string digit = Convert.ToString(number);
if(digit.Length > 2)
{
    Console.WriteLine("Третья цифра числа: " + digit[2]);
}
else
{
    Console.Write("Третьей цифры нет");
}