using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace Game4.PlayersAndClasses
{
    public class Item
    {
        #region Fields

        private Texture2D itemPick;
        private string name;
        private int value;

        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public Item(Texture2D itemPick, string name, int value)
        {
            this.ItemPick = itemPick;
            this.Name = name;
            this.Value = value;
        }

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

        public int Value
        {
            get { return this.value; }

            set { this.value = value; } //TODO: tva e malko 6it kazavo da se fixne

        }
        #endregion
    }
}
