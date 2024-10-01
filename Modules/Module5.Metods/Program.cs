using System.Collections.Generic;
using System.Reflection;
using System.Xml.Linq;

namespace Module5.Metods
{
    internal class Program
    {
        /// <summary>
        /// Самый большой возраст
        /// </summary>
        const byte theOldest = 150;

        /// <summary>
        /// Чтение из консоли непустой строки из консоли
        /// </summary>
        /// <param name="textQuestion">Текст запроса пользователю</param>
        /// <returns>Непустая введеная пользователем строка</returns>
        static string ReadStringFromConsole (string textQuestion)
        {
            string textAnswer;
            Console.WriteLine($"{textQuestion}");
            textAnswer = Console.ReadLine();
            while (String.IsNullOrWhiteSpace(textAnswer))
            {
                Console.WriteLine("Ошибка, попробуйте ввести снова.");
                Console.WriteLine($"{textQuestion}");
                textAnswer = Console.ReadLine();
            }            
            return textAnswer;
        }

        /// <summary>
        /// Чтение из консоли возраста
        /// </summary>
        /// <param name="textQuestion">Текст запроса пользователю</param>
        /// <returns>Натуральное число - возраст</returns>
        static byte ReadAgeFromConsole(string textQuestion)
        {
            byte answer;
            Console.WriteLine($"{textQuestion}");
            string ageAnswer = Console.ReadLine();
            while (String.IsNullOrWhiteSpace(ageAnswer)
                || !byte.TryParse(ageAnswer, out answer)
                || !(answer <= theOldest)
                || !(answer != 0))
            {
                Console.WriteLine("Ошибка, попробуйте ввести снова.");
                Console.WriteLine($"{textQuestion}");
                ageAnswer = Console.ReadLine();
            }
            return answer;
        }

        /// <summary>
        /// Чтение из консоли наличия питомцев у пользователя
        /// </summary>
        /// <param name="textQuestion">Текст запроса пользователю</param>
        /// <returns>true при наличии питомцев у пользователя, false - при отсутствии</returns>
        static bool ReadHasPetFromConsole(string textQuestion) 
        {
            Console.WriteLine($"{textQuestion}");
            string hasPetAnswer = Console.ReadLine();
            while (String.Compare(hasPetAnswer, "Да", true) != 0
                && String.Compare(hasPetAnswer, "Нет", true) != 0)
            {
                Console.WriteLine("Ошибка, попробуйте ввести снова.");
                Console.WriteLine($"{textQuestion}");
                hasPetAnswer = Console.ReadLine();
            }
            if (String.Compare(hasPetAnswer, "Да", true) == 0)
            {
                return true;
            }
            else if (String.Compare(hasPetAnswer, "Нет", true) == 0)
            {
                return false;
            }
            return false;
        }

        /// <summary>
        /// Проверка введенного в консоль пользователем числа
        /// </summary>
        /// <param name="answerCount">Ответ пользователя</param>
        /// <param name="mayBeNull">Флаг может ли число быть равно 0</param>
        /// <param name="count">Число введенное пользователем</param>
        /// <returns>true если число введено верно, false - не верно</returns>
        static bool CheckCountNumber(string answerCount, bool mayBeNull, out int count)
        {
            int temp;
            if (!String.IsNullOrWhiteSpace(answerCount)
                && Int32.TryParse(answerCount, out temp)
                && temp >= 0)
            {
                if (mayBeNull && temp == 0)
                {
                    count = 0;
                    return true;
                }
                else if (!mayBeNull && temp == 0)
                {
                    count = -1;
                    return false;
                }
                else
                {
                    count = temp;
                    return true;
                }
            }
            else
            {
                count = -1;
                return false;
            }
        }

        /// <summary>
        /// Чтение из консоли количества чего-либо
        /// </summary>
        /// <param name="textQuestion">Текст запроса пользователю</param>
        /// <param name="mayBeNull">Флаг может ли количество быть равно 0</param>
        /// <returns>Количество введенное пользователем</returns>
        static int ReadCountNumber(string textQuestion, bool mayBeNull)
        {
            int countNumber = -1;
            Console.WriteLine($"{textQuestion}");
            string answerCount = Console.ReadLine();
            while (!CheckCountNumber(answerCount, mayBeNull, out countNumber))
            {
                Console.WriteLine("Ошибка, попробуйте ввести снова.");
                Console.WriteLine($"{textQuestion}");
                answerCount = Console.ReadLine();
            }            
            return countNumber;
        }

        /// <summary>
        /// Чтение из консоли массива строк
        /// </summary>
        /// <param name="textQuestion">Текст запроса пользователю</param>
        /// <param name="count">Размер массива строк</param>
        /// <returns>Массив строк</returns>
        static string[] ReadStringArr(string textQuestion, int count)
        {
            string[] stringArr = new string[count];
            
            for (int i = 0; i < count; i++)
            {
                stringArr[i] = ReadStringFromConsole($"{textQuestion} №{i + 1} и нажмите Enter:");
            }
            return stringArr;
        }

        /// <summary>
        /// Формирование анкеты по вводу пользователем информации в консоли
        /// </summary>
        /// <returns>Анкета пользователя</returns>
        static (string name, string lastName, byte age, bool hasPet, string[] petNames, string[] favoriteColors) ReadUserAnketa()
        {
            (string name, string lastName, byte age, bool hasPet, string[] petNames, string[] favoriteColors) userAnketa;
            userAnketa.name = ReadStringFromConsole("Введите своё имя:");
            userAnketa.lastName = ReadStringFromConsole("Введите свою фамилию:");
            userAnketa.age = ReadAgeFromConsole($"Введите количество полных лет числом от 1 до {theOldest}:");
            userAnketa.hasPet = ReadHasPetFromConsole("У Вас есть питомцы? Да/Нет");
            userAnketa.petNames = [];
            if (userAnketa.hasPet)
            {
                int petCount = ReadCountNumber($"Сколько у Вас питомцев? Введите целым числом больше 0:", false);
                Console.WriteLine($"Какие клички у питомцев?");
                userAnketa.petNames = ReadStringArr($"Введите кличку питомца", petCount);
            }
            userAnketa.favoriteColors = [];
            int colorsCount = ReadCountNumber($"Сколько у Вас любимых цветов? Введите целым числом от 0 и больше:", true);
            if (colorsCount > 0)
            {
                userAnketa.favoriteColors = ReadStringArr($"Введите любимый цвет", colorsCount);
            }
            return userAnketa;
        }

        /// <summary>
        /// Вывод в консоль анкеты пользователя
        /// </summary>
        /// <param name="anketa">Анкета пользователя</param>
        static void WriteAnketaToConsole ((string name, string lastName, byte age, bool hasPet, string[] petNames, string[] favoriteColors) anketa)
        {
            Console.WriteLine("Ваше имя: {0}", anketa.name);
            Console.WriteLine("Ваша фамилия: {0}", anketa.lastName);
            Console.WriteLine("Ваш возраст: {0}", anketa.age);
            if (anketa.hasPet)
            {
                Console.WriteLine("У Вас есть питомцы:");
                for (int i = 0; i < anketa.petNames.Length; i++)
                {
                    Console.WriteLine("питомец №{0}: {1}", i + 1, anketa.petNames[i]);
                }
            }
            else
            {
                Console.WriteLine("У Вас нет питомцев");
            }

            if (anketa.favoriteColors.Length > 0)
            {
                Console.WriteLine("Ваши любимые цвета:");
                for (int j = 0; j < anketa.favoriteColors.Length; j++)
                {
                    Console.WriteLine("цвет №{0}: {1}", j + 1, anketa.favoriteColors[j]);
                }
            }
            else
            {
                Console.WriteLine("У Вас нет любимых цветов");
            }
        }


        /// <summary>
        /// MAIN
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {   

            (string name, string lastName, byte age, bool hasPet, string[] petNames, string[] favoriteColors) userAnketa = ReadUserAnketa();

            WriteAnketaToConsole(userAnketa);

            Console.ReadKey();
        }
    }
}
