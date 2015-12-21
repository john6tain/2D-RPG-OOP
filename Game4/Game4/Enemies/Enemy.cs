using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGGame.Enemies
{
   abstract class Enemy
    {
       int health, damage;
       public abstract int TakeDamage(Player player);
       public abstract int HitDamage(Player player);

        public Enemy(int health, int damage)
        {
            this.Health = health;
            this.Damage = damage;
        }

        public int Damage
        {
            get { return this.damage; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Damage cannot be negative");
                }
                this.damage = value;
            }
        }

        public int Health
        {
            get { return this.health; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Health cannot be negative");
                }
                this.health = value;

            }
        }


    }
}
