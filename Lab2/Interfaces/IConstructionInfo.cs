using Lab2.Constructions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Interfaces
{
    interface IConstructionInfo
    {
        double Height { get; }
        double Width { get; }
        int Entrances { get; }
        int HumanCapacity { get; }
        BuildMaterialType BuildMaterial { get; }

        void DisplayConstructionInfo();


    }

}
