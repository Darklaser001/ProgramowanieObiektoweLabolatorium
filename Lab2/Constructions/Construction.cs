using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Constructions
{
    class Construction
    {
        public Construction(double height, double width, int entrances, int humanCapacity, string buildMaterial)
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
        public string BuildMaterial { get; set; }
    }
}

/*
1. Height typu zmiennoprzecinkowego
2. Width typu zmiennoprzecinkowego
3. Entrances typu liczba całkowita
4. HumanCapacity typu liczba całkowita
5. BuildMaterial typu tekstowego
*/