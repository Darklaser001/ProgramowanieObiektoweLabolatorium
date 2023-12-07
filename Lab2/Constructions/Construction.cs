using Lab2.Constructions.Models;
using Lab2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Constructions
{
    class Construction: ISquareCost, IConstructionInfo
    {
        public Construction(double height, double width, int entrances, int humanCapacity, BuildMaterialType buildMaterial)
        {
            this.Height = height;
            this.Width = width;
            this.Entrances = entrances;
            this.HumanCapacity = humanCapacity;
            this.BuildMaterial = buildMaterial;
        }

        public double Height { get; set; }
        public double Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }
        public BuildMaterialType BuildMaterial {
            get
            {
                return _buildMaterial;
            }
            set
            {
                /*
                                if(value == string.Empty)
                                {
                                    throw new ArgumentNullException();
                                }
                                _buildMaterial = value;
                */
                _buildMaterial = value;
            }
        }
        private BuildMaterialType _buildMaterial { get; set; }

        public Construction()
        {
            this.Height = 6;
            this.Width = 1;
            this.Entrances = 9;
            this.HumanCapacity = 13;
            this.BuildMaterial = BuildMaterialType.Wood;
        }

        public Construction(CreateConstructionDto input)
        {
            this.Height = input.Height;
            this.Width = input.Width;
            this.Entrances = input.Entrances;
            this.HumanCapacity = input.HumanCapacity;
            this.BuildMaterial = BuildMaterialType.Wood;
        }

        public double GetSquareCost()
        {
            var x = 0.0;
            if (_buildMaterial == BuildMaterialType.Concrete)
            {
                x = 0.87;
            }
            if (_buildMaterial == BuildMaterialType.Brick)
            {
                x = 0.8;
            }
            if (_buildMaterial == BuildMaterialType.Wood)
            {
                x = 0.78;
            }
            return Width * Height * 0.9 * x;
        }

        public double CalculateSquareCost()
        {
            return GetSquareCost();
        }

        public void DisplayCostDetails()
        {
            Console.WriteLine($"Square cost details for the building:");
            Console.WriteLine($"Height: {Height}, Width: {Width}, Entrances:{ Entrances}, Human Capacity: { HumanCapacity}, Build Material:{ BuildMaterial}");
            Console.WriteLine($"Square Cost: {CalculateSquareCost()}");
        }

        public void DisplayConstructionInfo()
        {
            Console.WriteLine($"Construction information for the building: "); Console.WriteLine($"Height: {Height}, Width: {Width}, Entrances: { Entrances}, Human Capacity: { HumanCapacity}, Build Material: { BuildMaterial}");
        }
    }

}

/*
1. Height typu zmiennoprzecinkowego
2. Width typu zmiennoprzecinkowego
3. Entrances typu liczba całkowita
4. HumanCapacity typu liczba całkowita
5. BuildMaterial typu tekstowego
*/