int a = InpNum("Введите число строк 1-й матрицы: ");
int b = InpNum("Введите число столбцов 1-й матрицы: ");
int c = InpNum("Введите число строк 2-й матрицы: ");
int d = InpNum("Введите число столбцов 2-й матрицы: ");
int range = InpNum("Диапазон: от 1 до ");

int[,] FirstMatrix = new int[a, b];
CreateAndWriteArray(FirstMatrix);
Console.WriteLine();
int[,] SecondMatrix = new int[c, d];
CreateAndWriteArray(SecondMatrix);

int[,] result = new int[a, d];
Multiplication(FirstMatrix, SecondMatrix, result);
Console.WriteLine();
Console.WriteLine($"Результат:");
CreateAndWriteArray(result);

void Multiplication(int[,] FirstMatrix, int[,] SecondMatrix, int[,] result)
{
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < FirstMatrix.GetLength(1); k++)
      {
        sum += FirstMatrix[i,k] * SecondMatrix[k,j];
      }
      result[i,j] = sum;
    }
  }
}

int InpNum(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateAndWriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
      Console.Write(array[i, j] + " ");
    } 
    Console.WriteLine();
  }
}