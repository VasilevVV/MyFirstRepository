namespace Module3.BaseC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Jane";
            byte MyAge = 27;
            bool IHaveAPet = true;
            double MyShoeSize = 37.5;

            Console.WriteLine($"My name is {MyName}");
            Console.WriteLine($"My age is {MyAge}");
            Console.WriteLine($"Do I have a pet? {IHaveAPet}");
            Console.WriteLine($"My shoe size is {MyShoeSize}");


            Console.ReadKey();
        }
    }
}
