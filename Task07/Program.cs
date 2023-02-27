Console.WriteLine("введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 0) number = number *= -1;
if(number > 99 && number < 1000)
{
    int restult = number % 10;
    Console.Write(restult);
}
else
{
    Console.Write("Нужно вветси трехначное число");
}