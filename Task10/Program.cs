Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(number);
Console.WriteLine("Вторая цифра числа: " + stringNumber[1]);
