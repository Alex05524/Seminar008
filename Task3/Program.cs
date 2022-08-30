internal partial class Program
{
    private static void Main(string[] args)
    {
        int a = InNum("A: ");
        int b = InNum("B: ");
        int c = InNum("C: ");
        Console.WriteLine("");

        int[,,] ThirdMass = new int[a, b, c];
        CreateArray(ThirdMass);
        WriteArray(ThirdMass);

        int InNum(string input)
        {
            Console.Write(input);
            int output = Convert.ToInt32(Console.ReadLine());
            return output;
        }

        void WriteArray(int[,,] ThirdMass)
        {
            for (int i = 0; i < ThirdMass.GetLength(0); i++)
            {
                for (int j = 0; j < ThirdMass.GetLength(1); j++)
                {
                    for (int k = 0; k < ThirdMass.GetLength(2); k++)
                    {
                        Console.WriteLine($"{ThirdMass[i, j, k]}({i},{j},{k});");
                    }
                }
            }
        }

        void CreateArray(int[,,] ThirdMass)
        {
            int[] temp = new int[ThirdMass.GetLength(0) * ThirdMass.GetLength(1) * ThirdMass.GetLength(2)];
            int num;
            for (int i = 0; i < temp.GetLength(0); i++)
            {
                temp[i] = new Random().Next(10, 100);
                num = temp[i];
                if (i >= 1)
                {
                    for (int j = 0; j < i; j++)
                    {
                        while (temp[i] == temp[j])
                        {
                            temp[i] = new Random().Next(10, 100);
                            j = 0;
                            num = temp[i];
                        }
                        num = temp[i];
                    }
                }
            }
            int count = 0;
            for (int a = 0; a < ThirdMass.GetLength(0); a++)
            {
                for (int b = 0; b < ThirdMass.GetLength(1); b++)
                {
                    for (int c = 0; c < ThirdMass.GetLength(2); c++)
                    {
                        ThirdMass[a, b, c] = temp[count];
                        count++;
                    }
                }
            }
        }
    }
}