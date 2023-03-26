int numberM = Input("Введите целое положительное число M: ");
int numberN = Input("Введите целое положительное число N: ");
NaturalNumbersMtoN(numberM, numberN);

int Input(string text)
{
Console.Write(text);
return Convert.ToInt32(Console.ReadLine());
}

void NaturalNumbersMtoN(int numM, int numN)
{
if (numM < numN)
{
Console.Write($"{numM} ");
NaturalNumbersMtoN(numM + 1, numN);
}

else if (numM > numN)
{
Console.Write($"{numM} ");
NaturalNumbersMtoN(numM - 1, numN);
}

else
{
Console.Write($"{numM}");
}
}