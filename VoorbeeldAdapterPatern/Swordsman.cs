using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoorbeeldAdapterPatern
{
    public class Swordsman : Soldier
    {
        public void DescribeArmor()
        {
            Console.WriteLine("I am wearing full body platemail.");
        }

        public void ExecuteAttack()
        {
            Console.WriteLine("*Sound of sword slashing*");
        }
    }
}
