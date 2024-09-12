namespace Module3.BaseC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 4.5.1            
            (string Name, string LastName, string Login, int LoginLenght, bool HasPet, double Age, string[] favcolors) User;

            //Task 4.5.6
            for (int j = 0; j < 3; j++)
            {
                //Task 4.5.2
                Console.WriteLine("Введите имя");
                User.Name = Console.ReadLine();

                Console.WriteLine("Введите фамилию");
                User.LastName = Console.ReadLine();

                Console.WriteLine("Введите логин");
                User.Login = Console.ReadLine();

                //Task 4.5.3
                User.LoginLenght = User.Login.Length;

                //Task 4.5.4
                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                string answerHasPet = Console.ReadLine();
                if (answerHasPet == "Да" || answerHasPet == "да")
                {
                    User.HasPet = true;
                }
                else
                {
                    User.HasPet = false;
                }

                //Task 4.5.5
                Console.WriteLine("Введите возраст пользователя");
                int countTry = 0;
                while (true)
                {                    
                    string answerAge = Console.ReadLine();
                    double age;
                    if (double.TryParse(answerAge, out age) && age < 120.0)
                    {
                        User.Age = age;
                        break;
                    }
                    Console.WriteLine("Введите возраст корректно");
                    countTry++;
                    if (countTry > 100)
                    {
                        User.Age = 0;
                        break;
                    }
                }
                User.favcolors = new string[3];
                Console.WriteLine("Введите три любимых цвета пользователя");
                for (int i = 0; i < User.favcolors.Length; i++)
                {
                    Console.WriteLine($"Введите {i + 1} любимый цвет");
                    User.favcolors[i] = Console.ReadLine();
                }
            }


            Console.ReadKey();
        }


    }
}
