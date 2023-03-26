int Input(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int SumOfElements(int m, int n)
{
  if (m == n) return m;
  else return SumOfElements(m + 1, n) + m;
}

int m = Input("Введите число M: ");
int n = Input("Введите число N: ");

Console.WriteLine(SumOfElements(m, n));