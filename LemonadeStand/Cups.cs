using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Cups
    {
        private double CupCost;

        public Cups()
        {
            CupCost = .03;
        }

        public double GetCupCost()
        {
            return CupCost;
        }
        
    }
}
