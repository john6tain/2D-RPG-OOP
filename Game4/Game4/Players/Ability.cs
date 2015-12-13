using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPGGame.PlayersAndClasses;
using Microsoft.Xna.Framework.Graphics;

namespace RPGGame.Players
{
    public abstract class Ability
    {
        #region Fields
        /// <summary>
        /// Ability Fields
        /// </summary>
        protected string abilityName;
        protected int abilityValue;

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="abilityName"></param>
        /// <param name="abilityValue"></param>
        public Ability(string abilityName, int abilityValue)
        {
            this.AbilityName = abilityName;
            this.AbilityValue = abilityValue;
        }

        #endregion

        #region Properties
        /// <summary>
        /// Properties
        /// </summary>
        public int AbilityValue
        {
            get { return this.abilityValue; }
            set { this.abilityValue = value; }
        }

        public string AbilityName
        {
            get { return this.abilityName; }
            set { this.abilityName = value; }
        }

        #endregion

        #region Methods
        /// <summary>
        /// Add Item Method
        /// </summary>
        /// <param name="item"></param>
        public void AddItem(Item item)
        {
            this.abilityValue += item.AmountBonus;
        }

        #endregion
    }
}
