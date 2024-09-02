namespace Module3.BaseC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = 10.0 * 2.0 / 5.0;
            Console.WriteLine("Value: {0}", result);

            double result2 = 5.0 / 2.0 * 3.0;
            Console.WriteLine("Value: {0}", result2);

            double result3 = 10 % 3;
            Console.WriteLine("Value: {0}", result3);

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
