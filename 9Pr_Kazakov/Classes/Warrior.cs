using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Pr_Kazakov.Classes
{
    public class Warrior
    {
        public double Health { get; set; }

        public bool IsAlive => Health > 0;

        public Warrior(double initialHealth = 100)
        {
            Health = initialHealth;
        }

        public virtual double TakeDamage(double damage)
        {
            Health -= damage;
            if (Health < 0) Health = 0;
            return  Health;
        }
    }
}
