using System.Reflection;

namespace Module5.Metods
{
    internal class Program
    {
        
        static void Echo(string phrase, int deep)
        {
            var modif = phrase;
            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }

            Console.BackgroundColor = (ConsoleColor)deep;
            Console.WriteLine("..." + modif);
            Console.ResetColor();

            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }
        }

        static decimal Factorial(decimal x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }

        private static int PowerUp(int N, byte pow)
        {
            if (pow == 0) 
            { 
                return 1; 
            }
            else if (pow == 1)
            {
                return N;
            }
            else
            {
                return N * PowerUp(N, --pow);
            }

            
        }

        /// <summary>
        /// MAIN
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите что-то");
            var str = Console.ReadLine();

            Console.WriteLine("Укажите глубину эха");
            var deep = int.Parse(Console.ReadLine());

            Echo(str, deep);

            Console.WriteLine(Factorial(20));

            Console.WriteLine(PowerUp(5, 3));

            Console.ReadKey();
        }
    }
}
