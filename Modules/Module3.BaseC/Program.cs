namespace Module3.BaseC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MyName = "Jane";
            Console.WriteLine(MyName);

            Console.WriteLine("\tПривет, мир");
            Console.WriteLine("\tМне 27 лет");
            Console.WriteLine("\t My name is \n {0}", MyName);
            Console.WriteLine("\u0040");
            Console.WriteLine("\u0023");

            Console.WriteLine(true);
            Console.WriteLine(false);

            Console.WriteLine(5);

            Console.WriteLine(0x0A);
            Console.WriteLine(0b11);
            Console.WriteLine(5.5);

            Console.ReadKey();
        }
    }
}
