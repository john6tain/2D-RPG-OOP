using System;
using Microsoft.Xna.Framework.Graphics;
using RPGGame.Players;

/// <summary>
/// Alex made this class
/// #Alexsination
/// #Energy
/// </summary>


namespace RPGGame.PlayersAndClasses
{
    public class Alexsination : Character
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>

        public Alexsination(double x, double y)
            : base(x, y)
        {
            this.Energy = 100;
            this.Life = 100 * this.Energy;
            this.Speed += this.Energy / 100;
            this.Damage += Energy * 80;
        }

        public Alexsination(double x, double y, Texture2D[] pics, double life, Ability shadowStep, int damage, int speed, int energy)
            : base(x, y, pics, life, shadowStep, damage, speed)
        {
            this.Energy = 100;
        }
        public override string ToString()
        {
            return String.Format("Life : {0} Energy: ", Life, Energy);
        }
        #endregion

    }
}