using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static RPGGame.Player;

namespace RPGGame.Enemies
{
    class Mob : Enemy
    {
        public Mob(int health = 5000, int damage = 100) : base(health, damage)
        { 
        }


        public override int TakeDamage(Player player)
        {
            this.Health = this.Health - player.Damage;
            return this.Health;
        }

        public override int HitDamage(Player player)
        {
            player.Life = player.Life - this.Damage;
            return player.Life;
        }

        
    }
}
