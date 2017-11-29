using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Sugar
    {
        private double SugarCost = .02;
        private string SugarName;

        public double GetSugarCost()
        {
            return SugarCost;
        }

        public string GetSugarName()
        {
            return SugarName;
        }
    }
}
