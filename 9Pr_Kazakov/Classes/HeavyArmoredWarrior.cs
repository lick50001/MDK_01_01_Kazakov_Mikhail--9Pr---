using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Pr_Kazakov.Classes
{
    public class HeavyArmoredWarrior : Warrior
    {


        public HeavyArmoredWarrior(double initialHealth = 100) : base(initialHealth) { }

        public override double TakeDamage(double damage)
        {
            Health -= damage * 0.5;

            if (Health < 0) Health = 0;

            return Health;
        }
    }
}
