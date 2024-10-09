namespace Module6.Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var department = GetCurrentDepartment();

            if (department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
            {
                Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
            }

            Console.ReadKey();
        }

        static Department GetCurrentDepartment()
        {
            // logic 
        }
    }

    class Company
    {
        public string Type;
        public string Name;
    }

    class Department
    {
        public Company Company;
        public City City;
    }

    class City
    {
        public string Name;
    }

}
