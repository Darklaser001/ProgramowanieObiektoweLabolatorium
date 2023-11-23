using Lab2.Constructions;
using Lab2.Constructions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.IndustrialHalls
{
    class IndustrialHall : Construction
    {
        public IndustrialHall(): base(15, 20, 2, 40, BuildMaterialType.Brick)
        {
            Console.WriteLine("Constructor of industrial hall");
        }


    }
}
