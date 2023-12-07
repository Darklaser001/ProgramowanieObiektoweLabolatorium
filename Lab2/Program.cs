using Lab2.Constructions;
using Lab2.IndustrialHalls;
using Lab2.ResidentalBuildings;
using Lab2.Constructions.Models;
using System;
using Lab2.BuildingWrappers;
using Lab2.CommercialBuildings;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var construction = new Construction(12, 34, 5, 6, BuildMaterialType.Wood, "lol");

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


            var industrialHall = new IndustrialHall();
            var residentalBuilding = new ResidentalBuilding(2);

            Console.WriteLine(industrialHall.BuildMaterial);
            Console.WriteLine(industrialHall.Height);
            Console.WriteLine(industrialHall.Width);
            Console.WriteLine(residentalBuilding.BuildMaterial);
            Console.WriteLine(residentalBuilding.Height);
            Console.WriteLine(residentalBuilding.Width);

            var buildingWrapperOne = new BuildingWrapper(industrialHall);
            var buildingWrapperTwo = new BuildingWrapper(residentalBuilding);

            Console.WriteLine(buildingWrapperOne.GetWrappedSquareCost());

            var commercialBuilding = new CommercialBuilding(12, 34, 5, 6, BuildMaterialType.Wood, "hello");
            commercialBuilding.OpenBusiness();
            Console.WriteLine(commercialBuilding.BuildMaterial);
            Console.WriteLine(commercialBuilding.Height);
            Console.WriteLine(commercialBuilding.Width);

        }
    }
}
