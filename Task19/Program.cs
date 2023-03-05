Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();

if (number!.Length == 5)
{
    CheckingNumber(number);
}
else Console.WriteLine($"Введи правильное число");

void CheckingNumber(string number)
{
    if (number[0]==number[4] || number[1]==number[3])
    {
        Console.WriteLine($"Ваше число: {number} - палиндром.");
    }    
    else Console.WriteLine($"Ваше число: {number} - Не палиндром.");
}

