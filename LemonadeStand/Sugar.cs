using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Sugar
    {
        
        public double SugarCost { get; private set; }

        public double GetSugarCost()
        {
            return SugarCost = .08;
        }
    }
}
