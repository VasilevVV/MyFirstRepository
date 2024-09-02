namespace Module3.BaseC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Евгения";
            Console.WriteLine("Привет, мир");
            Console.WriteLine();
            Console.WriteLine("Меня зовут {0}", MyName);

            //0 — позиция нашей переменной. То есть переменная будет на позиции 0.


            //Также мы можем вставить в строку не переменную, а строковый литерал:
            Console.WriteLine("Меня зовут {0}", "Маша");


            //И, естественно, мы можем использовать несколько переменных при выводе. В этом случае располагаем их в порядке нумерации «мест».
            var age = 27;
            var weight = 50;
            
            Console.WriteLine("Возраст {0} \n Вес {1}", age, weight);

            string favcolor = "black";
            string name = "Jane";
            Console.WriteLine("{0}\n  {1} \n {2}", name, age, favcolor);


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
