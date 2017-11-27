using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class UserInterface
    {
        public void Welcome()
        {
            Console.WriteLine("Welcome to lemonade stand, would you like to: \n'1' Play Alone \n'2'Play the Computer");
            Console.ReadLine();
        }
    }
}
