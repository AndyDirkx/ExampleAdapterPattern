using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoorbeeldAdapterPatern
{
    public class ArcherAdapter : Soldier
    {
        private Ranged ranger;

        public ArcherAdapter(Ranged ranger)
        {
            this.ranger = ranger;
        }

        public void DescribeArmor()
        {
            ranger.DescribeClothes();
        }

        public void ExecuteAttack()
        {
            ranger.ShootArrow();
        }
    }
}
