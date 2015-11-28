using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game4.PlayersAndClasses;
using Microsoft.Xna.Framework.Graphics;

namespace Game4.Players
{
    public class Ability
    {
        #region Fields

        /// <summary>
        /// FIELDS Ability
        /// </summary>
        protected string abilityName;
        protected int abilityValue;

        #endregion

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


        /// <summary>
        /// Add Item Method
        /// </summary>
        /// <param name="item"></param>
        public void AddItem(Item item)
        {
            this.abilityValue += item.Value;
        }
    }
}
