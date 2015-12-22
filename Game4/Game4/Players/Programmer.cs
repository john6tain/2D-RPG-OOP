﻿using Microsoft.Xna.Framework.Graphics;
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
        }

        public Programmer(double x, double y, Texture2D pic, double life, Ability hackingDoors, int damage, int speed, int coffeine)
            : base(x, y, pic, life, hackingDoors, damage, speed)
        {
            this.Coffeine = 500;
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

    }
}