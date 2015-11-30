using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace Game4.PlayersAndClasses
{
    public abstract class Trinket
    {
        private Texture2D pic;
        private string name;
        private string bonus;

        protected Trinket(Texture2D pic, string name, string bonus)
        {
            this.Pic = pic;
            this.Name = name;
            this.Bonus = bonus;
        }

        public string Bonus
        {
            get {return this.Bonus; }
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
    }
}
