double[] GenerateArray()
{
    double[] array = new double[5];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * 100;
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

double[] array = GenerateArray();
PrintArray(array);
System.Console.WriteLine(PrintArray(array));
Difference(array);