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

            Console.WriteLine("IntMin {0} ", int.MinValue);
            Console.WriteLine("IntMax {0} ", int.MaxValue);


            DaysOfWeekTo MyFavoriteDay;
            MyFavoriteDay = DaysOfWeekTo.Friday;
            Console.WriteLine(MyFavoriteDay);


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
