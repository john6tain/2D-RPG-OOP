using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace Game4.Tringket
{
    /// <summary>
    /// John made this class
    /// #Trinket
    /// #
    /// </summary>
    public abstract class Trinket
    {
        #region Fields
        /// <summary>
        /// Fields
        /// </summary>
        private Texture2D pic;
        private string name;
        private string bonus;
        private int percent;

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        protected Trinket(Texture2D pic, string name, string bonus, int percent)
        {
            this.Pic = pic;
            this.Name = name;
            this.Bonus = bonus;
            this.Percent = percent;
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public int Percent
        {
            get { return this.Percent; }
            set { this.Percent = value; }
        }
        public string Bonus
        {
            get { return this.Bonus; }
            set { this.Bonus = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public Texture2D Pic
        {
            get { return this.pic; }
            set { this.pic = value; }
        }

        #endregion
    }
}
