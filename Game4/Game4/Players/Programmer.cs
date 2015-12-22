using System;
using Microsoft.Xna.Framework.Graphics;
using RPGGame.Players;

/// <summary>
/// John made this class
/// #Programmer
/// #Coffeine
/// </summary>

namespace RPGGame.PlayersAndClasses
{
    public class Programmer : Character
    {
        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>

        public Programmer(double x, double y)
            : base(x, y)
        {
            this.Coffeine += 50;
            this.Life = 100*this.Coffeine;
            this.Speed += this.Coffeine/25;
            this.Damage += Coffeine/40;
        }

        public Programmer(double x, double y, Texture2D[] pics, double life, Ability hackingDoors, int damage, int speed,
            int coffeine)
            : base(x, y, pics, life, hackingDoors, damage, speed)
        {
            
        }

        #endregion
        public override string ToString()
        {
            return String.Format("Life {0} Coffeine ", Life,this.Coffeine);
        }
    }
}