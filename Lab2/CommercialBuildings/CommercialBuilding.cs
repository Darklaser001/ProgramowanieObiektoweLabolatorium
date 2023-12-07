using Lab2.Constructions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.CommercialBuildings
{
    class CommercialBuilding : AbstractCommercialBuildings
    {
        public CommercialBuilding(float height, float width, int entrances, int humanCapacity, BuildMaterialType buildMaterial, string businessType) : base(height, width, entrances, humanCapacity, buildMaterial, businessType)
        {
        }

        public override void OpenBusiness()
        {
            Console.WriteLine($"The {BusinessType} business is now open in the commercial building!");
        }
    }
}
