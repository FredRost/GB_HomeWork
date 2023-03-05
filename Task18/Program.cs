Console.WriteLine("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());

string coord = Coord(number);
Console.WriteLine(coord);

string Coord(int num)
{
    if(num == 1) return "x > 0 и y > 0";
    if(num == 2) return "x < 0 и y > 0";
    if(num == 3) return "x < 0 и y < 0";
    if(num == 4) return "x > 0 и y < 0";
    return "Введена некорректная четверть";
}

