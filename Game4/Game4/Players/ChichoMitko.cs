using System;
using Microsoft.Xna.Framework.Graphics;
using RPGGame.Players;

/// <summary>
/// Marto made this class
/// #ChichoMitko
/// #Focus
/// </summary>

namespace RPGGame.PlayersAndClasses
{
    public class ChichoMitko : Character
    {
        #region Constructor
        /// <summary>
        ///  Constructors
        /// </summary>

        public ChichoMitko(double x, double y)
            : base(x, y)
        {
            this.Life = 1000;
            this.Damage = Focus/80;
            this.Focus = 100;
        }

        public ChichoMitko(double x, double y, Texture2D[] pics, double life, Ability miracleShot, int damage, int speed, int focus)
            : base(x, y, pics, life, miracleShot, damage, speed)
        {
            this.Focus = 100;
        }
        #endregion
        public override string ToString()
        {
            return String.Format("Life  {0} Focus  ",Life,this.Focus);
        }

    }
}