<<<<<<< HEAD
﻿using Microsoft.Xna.Framework.Graphics;
using RPGGame.Players;

namespace RPGGame.Enemies
{
    public class Mob : Enemy
    {

        #region Constructor

        public Mob(double x, double y)
            : base(x, y)
        {
        }

        public Mob(double x, double y, Texture2D pic, double life, Ability myAbility, int damage, int speed)
            : base(x, y, pic, life, myAbility, damage, speed)
        {
        }
        #endregion

        #region Action Methods

        public override void Attack(Character character)
        {
            throw new System.NotImplementedException();
        }

        public override void Defence(Character character)
        {
            throw new System.NotImplementedException();
        }

        #endregion
=======
﻿using System;
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

        
>>>>>>> origin/master
    }
}
