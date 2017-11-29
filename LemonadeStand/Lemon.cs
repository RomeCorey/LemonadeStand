using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Lemon
    {
        private double LemonCost = .02;
        private string LemonName;

        public double GetLemonCost()
        {
            return LemonCost;
        }

        public string GetLemonName()
        {
            return LemonName;
        }
    }
}
