Console.Write("Введи цифру дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int number) {
  if (number == 6 || number == 7) {
  Console.WriteLine("Этот день выходной");
  }
  else if (number < 1 || number > 7) {
    Console.WriteLine("Это не день недели");
  }
  else Console.WriteLine("Этот день не выходной");
}

CheckingTheDayOfTheWeek(number);
