﻿using Lab2.Constructions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.BuildingWrappers
{
    class BuildingWrapper
    {
        public BuildingWrapper(Construction construction)
        {
            _construction = construction;
        }
        public Construction _construction{ get; set; }

        public double GetWrappedSquareCost()
        {
            return _construction.CalculateSquareCost();
        }
        public void WrappedDisplayCostDetails()
        {
            _construction.DisplayCostDetails();
        }

        public void WrappedDisplayConstructionInfo()
        {
            _construction.DisplayConstructionInfo();
        }

    }
}
