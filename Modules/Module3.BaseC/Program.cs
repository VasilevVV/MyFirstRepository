﻿namespace Module3.BaseC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            (string Name, string Type, double Age, int NameCount) Pet;

            Console.WriteLine("Введите имя питомца");
            Pet.Name = Console.ReadLine();
            Pet.NameCount = Pet.Name.Length;

            Console.WriteLine("Введите вид питомца");
            Pet.Type = Console.ReadLine();

            Console.WriteLine("Введите возраст питомца");
            Pet.Age = double.Parse(Console.ReadLine());

            Console.WriteLine($"Удивительный питомец:\nName: {Pet.Name},\nNameCount: {Pet.NameCount},\nType: {Pet.Type},\nAge: {Pet.Age}.");

            Console.ReadKey();
        }


    }
}
