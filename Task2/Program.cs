internal partial class Program
{
    private static void Main(string[] args)
    {
        int m = InpNum("M: ");
        int n = InpNum("N: ");
        int range = InpNum("Диапазон: от 1 до ");

        int[,] array = new int[m, n];
        CreateArray(array);
        WriteArray(array);

        int minSumm = 0;
        int summ = SumElem(array, 0);
        for (int i = 1; i < array.GetLength(0); i++)
        {
            int tempSumm = SumElem(array, i);
            if (summ > tempSumm)
            {
                summ = tempSumm;
                minSumm = i;
                }
                }
Console.WriteLine($"Результат наименьшей суммы элементов: ({summ})");

int SumElem(int[,] array, int i)
{
    int sumLine = array[i,0];
    for(int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i,j];
        }
        return sumLine;
        }

int InpNum(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
    }

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
            }
            }
            }

void WriteArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
            }
            Console.WriteLine();
            }
            }
            }
            }