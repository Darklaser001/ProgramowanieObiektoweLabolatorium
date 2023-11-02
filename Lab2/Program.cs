using Lab2.Constructions;
using Lab2.Constructions.Models;
using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var construction = new Construction(12, 34, 5, 6, BuildMaterialType.Wood);

            Console.WriteLine(construction.BuildMaterial);
            Console.WriteLine(construction.Height);
            Console.WriteLine(construction.HumanCapacity);
            Console.WriteLine(construction.Width);
            Console.WriteLine(construction.Entrances);

            construction = new Construction();

            Console.WriteLine(construction.BuildMaterial);
            Console.WriteLine(construction.Height);
            Console.WriteLine(construction.HumanCapacity);
            Console.WriteLine(construction.Width);
            Console.WriteLine(construction.Entrances);
            
            var input = new CreateConstructionDto()
            {
                BuildMaterial = BuildMaterialType.Wood,
                Width = 41,
                Height = 91,
                Entrances = 3,
                HumanCapacity = 10
            };
            
            construction = new Construction(input);
           
            Console.WriteLine(construction.BuildMaterial);
            Console.WriteLine(construction.Height);
            Console.WriteLine(construction.HumanCapacity);
            Console.WriteLine(construction.Width);
            Console.WriteLine(construction.Entrances);

            Console.WriteLine("koszt: " + construction.GetSquareCost());
        }
    }
}
