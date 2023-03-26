Console.Clear();
int Input(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int Akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  if (m > 0 && n == 0) return Akkerman(m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));
}

int m = Input("Введите число M: ");
int n = Input("Введите число N: ");

Console.WriteLine($"A({m},{n}) = {Akkerman(m, n)}");