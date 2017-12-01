using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Sugar
    {
        private double SugarCost;

        public Sugar()
        {
            SugarCost = .09;
        }

        public double GetSugarCost()
        {
            return SugarCost;
        }        
    }
}
