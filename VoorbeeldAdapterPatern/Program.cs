using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoorbeeldAdapterPatern
{
    class Program
    {
        static void Main(string[] args)
        {
            Soldier soldier = new Swordsman();
            Attack(soldier);

            Ranged archer = new Archer();
            ArcherAdapter archerAdapter = new ArcherAdapter(archer);
            Attack(archerAdapter);
            Console.ReadKey();
        }

        public static void Attack(Soldier s)
        {
            s.DescribeArmor();
            s.ExecuteAttack();
            Console.WriteLine();
        }
    }
}
