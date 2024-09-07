namespace Module3.BaseC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[3][];

            array[0] = new int[2] { 1, 2 };
            array[1] = new int[3] { 1, 2, 3 };
            array[2] = new int[5] { 1, 2, 3, 4, 5 };

            foreach (var arr in array)
            {
                foreach (var item in arr)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }


            int[] array4315 = new int[] { 1, 2, 3, 4, 5, -5, 6, 9, 1, 2, -3, 0 };
            int countPolog = 0;

            foreach (int item in array4315)
            {
                Console.Write(item + " ");
                if (item > 0)
                {
                    countPolog++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Количество положительных чисел: " + countPolog);

            Console.WriteLine();
            int[,] arr4316 = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            countPolog = 0;
            for (int i = 0; i < arr4316.GetLength(0); i++)
            {
                for (int j = 0; j < arr4316.GetLength(1); j++)
                {
                    Console.Write(arr4316[i,j] + " ");
                    if (arr4316[i, j] > 0)
                    {
                        countPolog++;
                    }
                }
                Console.WriteLine();   
            }
            Console.WriteLine();
            Console.WriteLine("Количество положительных чисел: " + countPolog);

            Console.WriteLine();
            int[,] arr4317 = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            for (int i = 0; i < arr4317.GetLength(0); i++)
            {
                for (int j = 0; j < arr4317.GetLength(1); j++)
                {
                    for(int k = j + 1; k < arr4317.GetLength(1); k++)
                    {
                        if (arr4317[i, k] < arr4317[i, j])
                        {
                            int tempArr4317 = arr4317[i, j];
                            arr4317[i, j] = arr4317[i, k];
                            arr4317[i, k] = tempArr4317;
                        }                                               
                    }
                    Console.Write(arr4317[i, j] + " ");                    
                }
                Console.WriteLine();
            }



            Console.ReadKey();
        }


    }
}
