using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace RPGGame.PlayersAndClasses
{
    public abstract class Item
    {
        #region Fields
        private Texture2D itemPick;
        private string name;
        private int amountBonus;

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public Item(Texture2D itemPick, string name, int amountBonus)
        {
            this.ItemPick = itemPick;
            this.Name = name;
	        this.AmountBonus = amountBonus;
        }
        
        #endregion

        #region Properties
        /// <summary>
        /// Properties
        /// </summary>
        public Texture2D ItemPick
        {
            get { return this.itemPick; }
            set { this.itemPick = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int AmountBonus
        {
            get { return this.amountBonus; }
            set { this.amountBonus = value; }

        }

        #endregion
    }
}
