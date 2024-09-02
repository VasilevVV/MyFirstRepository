namespace Module3.BaseC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите имя: ");
            var name = Console.ReadLine();

            var age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);

            Console.Write("What is your favorite day of week? ");

            var day = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day is {0}", day);

            Console.ReadKey();
        }


        /// <summary>
        /// Аналог системному DayOfWeek
        /// </summary>
        enum DaysOfWeek : byte
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        /// <summary>
        /// DaysOfWeek из примера
        /// </summary>
        enum DaysOfWeekTo : byte
        {
            Tuesday,
            Monday,
            Wednesday,
            Friday
        }

        /// <summary>
        /// Светофор
        /// </summary>
        enum Semaphore : int
        {
            Red = 100,
            Yellow = 200,
            Green = 300
        }

        enum ProgramData
        {
            ProgramId = 123,
            AuthorId = 567
        }

    }
}
