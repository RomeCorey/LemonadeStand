using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {   public int CurrentDay = 0;
        public void IncrementDay()
        {
            CurrentDay++;
        }
        public int GetDay()
        {
            return CurrentDay;
        }
    
    }
}
