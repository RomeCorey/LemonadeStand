using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Lemon
    {
        public double LemonCost { get; private set; }

        public double GetLemonCost()
        {
            return LemonCost = .08;
        }

        
    }
}
