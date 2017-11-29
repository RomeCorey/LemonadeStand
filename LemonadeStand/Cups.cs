using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Cups
    {
        private double CupCost = .02;
        private string CupName;

        public double GetCupCost()
        {
            return CupCost;
        }

        public string GetCupName()
        {
            return CupName;
        }

    }
}
