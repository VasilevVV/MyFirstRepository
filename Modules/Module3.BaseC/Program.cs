namespace Module3.BaseC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = 10 / 4;
            Console.WriteLine("10 / 4 = {0}", result);

            double result2 = 14 % 7;
            Console.WriteLine("14 % 7 = {0}", result2);

            double result3 = 14 / 7;
            Console.WriteLine("14 / 7 = {0}", result3);

            double result4 = 14.0 / 7.0;
            Console.WriteLine("14.0 / 7.0 = {0}", result4);

            double result5 = 10.0 / 4.0;
            Console.WriteLine("10.0 / 4.0 = {0}", result5);

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
