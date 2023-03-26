int Input(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int NaturalNumber(int n, int m)
{
  if (n == m) return n;
  else Console.Write($"{NaturalNumber(n, m + 1)}, ");
  return m;
}

int n = Input("Введите положительное число: ");

if (n < 1)
{
  Console.WriteLine("Вы ввели не положительное число!");
  return;
}
Console.WriteLine(NaturalNumber(n, 1));