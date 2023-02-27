Console.WriteLine("Введите день недели: ");
string day = Console.ReadLine();
switch (day)
{
    case "1":
        {
            Console.WriteLine("Поденедельник");
            break;
        }
    case "2":
        {
            Console.WriteLine("Вторинк");
            break;
        }
    case "3":
        {
            Console.WriteLine("Среда");
            break;
        }
    case "4":
        {
            Console.WriteLine("Четверг");
            break;
        }
    case "5":
        {
            Console.WriteLine("Пятница");
            break;
        }
    case "6":
        {
            Console.WriteLine("Суббота");
            break;
        }
    case "7":
        {
            Console.WriteLine("Воскресенье");
            break;
        }
    default:
        {
            Console.WriteLine("Дня недели не существует");
            break;
        }
}