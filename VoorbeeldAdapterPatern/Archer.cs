using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoorbeeldAdapterPatern
{
    public class Archer : Ranged
    {
        public void DescribeClothes()
        {
            Console.WriteLine("My armor is made of leather hides.");
        }

        public void ShootArrow()
        {
            Console.WriteLine("*Sound of arrow being shot*");
        }
    }
}
