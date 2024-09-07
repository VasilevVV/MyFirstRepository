namespace Module3.BaseC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine();
            int[] arr4312 = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            Console.WriteLine("Массив который был:");
            for (int i = 0; i < arr4312.Length; i++)
            {
                Console.Write(arr4312[i] + " ");
            }
            Console.WriteLine();

            int maxarr4312 = 0;
            for (int i = 0; i < arr4312.Length; i++)
            {
                maxarr4312 += arr4312[i];
            }
            Console.WriteLine("Sum: " + maxarr4312);

            Console.WriteLine();
            for (int i = 0; i < arr4312.Order<int>().Count(); i++)
            {
                Console.Write(arr4312.Order<int>().ElementAt(i) + " ");
            }
            Console.WriteLine();

            

            Console.WriteLine();
            for (int i = 0; i < arr4312.Length; i++)
            {
                for (int j = i + 1; j < arr4312.Length; j++)
                {
                    if (arr4312[i] > arr4312[j])
                    {
                        int temp = arr4312[i];
                        arr4312[i] = arr4312[j];
                        arr4312[j] = temp;
                    }
                }                
                Console.Write(arr4312[i] + " ");
            }
            Console.WriteLine();


            Console.ReadKey();
        }


    }
}
