using System.Reflection;

namespace Module5.Metods
{
    internal class Program
    {
        static string ShowColor()
        {
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            var color = Console.ReadLine();
            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your color is yellow!");
                    break;
            }
            Console.ResetColor();
            return color;
        }

        static void ShowColors(string username = "Jane", params string[] favcolors)
        {
            Console.WriteLine($"{username}\nВаши любимые цвета:");
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }
        }

        static int[] GetArrayFromConsole(int num = 5)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }

        static int[] SortArrayAsc(int[] result)
        {
            int temp = 0;
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }
            return result;
        }

        static int[] SortArrayDesc(int[] result)
        {
            int temp = 0;
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] < result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }
            return result;
        }

        static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc)
        {
            sorteddesc = SortArrayDesc(array);
            sortedasc = SortArrayAsc(array);
        }


        static void ShowArray(int[] arr, bool isSort = false)
        {
            var temp = arr;
            if (isSort == true)
            {
                temp = SortArrayAsc(arr);
            }

            foreach (var item in temp)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine("");
        }

        static void GetName(ref string name)
        {
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();

        }

        static void ChangeAge(int age)
        {
            //Console.WriteLine("Введите возраст");
            //age = int.Parse(Console.ReadLine());
            age++;
        }

        static void BigDataOperation(in int[] arr)
        {
            arr[0] = 4;
        }


        static int SumNumbers(ref int num1, in int num2, out int num3, int num4)
        {
            var result = num1 + num2;
            num3 = result;

            return num4 * result;
        }

        static void Main(string[] args)
        {
            string someName = "Евгений";
            Console.WriteLine($"Имя1: {someName}");
            GetName(ref someName);
            Console.WriteLine($"Имя2: {someName}");


            int someAge = 27;
            Console.WriteLine($"Возраст1: {someAge}");
            ChangeAge(someAge);
            Console.WriteLine($"Возраст2: {someAge}");

            var arr = new int[] { 1, 2, 3 };
            ShowArray(arr);
            BigDataOperation(arr);
            Console.WriteLine(arr[0]);
            ShowArray(arr);

            Console.ReadKey();
        }
    }
}
