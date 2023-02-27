// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int restult = number % 10;
if(number % 2 == 0)Console.Write("Чётное число");
else
    {
      Console.Write("Нечётное число");
    }
