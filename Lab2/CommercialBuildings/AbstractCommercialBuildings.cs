using Lab2.Constructions;
using Lab2.Constructions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.CommercialBuildings
{
    abstract class AbstractCommercialBuildings: Construction
    {
        protected AbstractCommercialBuildings(float height, float width, int entrances, int humanCapacity, BuildMaterialType buildMaterial, string businessType): base(height, width, entrances, humanCapacity, buildMaterial)
        {
        }
    
        public string BusinessType { get; set; }

        public abstract void OpenBusiness();
    }
}
