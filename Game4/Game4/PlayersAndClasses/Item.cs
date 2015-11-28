using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace Game4.PlayersAndClasses
{
   public class Item
    {
        private Texture2D itePic;
        private string name;
        private int value;

       public Item(Texture2D itePic, string name, int value)
       {
           this.ItePic = itePic;
           this.Name = name;
           this.Value = value;
       }

       public Texture2D ItePic
       {
           get { return this.itePic; }

           set { this.itePic = value; }
           
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

    }
}
