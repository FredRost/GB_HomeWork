double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        //   System.Threading.Thread.Sleep(50);
        System.Console.Write($"{array[i]} ");
    }
}

void Difference (double[] array)
{
  double MaxValue = array[0];
  double MinValue = array[0];
  double result = 0;

  for (int i = 0; i < array.Length; i++)
  {
    if(array[i]> MaxValue)
    {
        MaxValue=array[i];
    }
    if(array[i]< MinValue)
    {
        MinValue = array[i];
    }
    
  }
  result = MaxValue - MinValue;
  System.Console.WriteLine($"Разница между максимальным ({MaxValue}) и минимальным ({MinValue}) элементами массива равна {result}");
}

double[] array = CreateArrayRndDouble(5, 1, 11);
PrintArray(array);
System.Console.WriteLine();
Difference(array);