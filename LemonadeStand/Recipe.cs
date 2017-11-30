using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {        
        public int GetLemonsPerPitcher()
        {            
            Console.WriteLine("How many lemons do you want in each pitcher?");
            string UserInput = Console.ReadLine();
            int LemonsPerPitcher = Int32.Parse(UserInput);
            return LemonsPerPitcher;            
        }

        public int GetIcePerPitcher()
        {
            Console.WriteLine("How much ice do you want in each pitcher?");
            string UserInput = Console.ReadLine();
            int IcePerPitcher = Int32.Parse(UserInput);
            return IcePerPitcher;
        }

        public int GetSugarPerPitcher()
        {
            Console.WriteLine("How much Sugar do you want in each pitcher?");
            string UserInput = Console.ReadLine();
            int SugarPerPitcher = Int32.Parse(UserInput);
            return SugarPerPitcher;
        }
    }
}
