using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace RPGGame.Items
{
    public abstract class BaseItem
    {
        #region Field

        protected List<Type> allowableClasses = new List<Type>();

        private string name;
        private string type;
        private int price;
        private float weight;
        private bool equipped;
        private Texture2D itemPic;
        private int amountBonus;


        #endregion

        #region Constructor
        //Armor, Weapon, Shield constructor
        public BaseItem(string name, string type, int price, float weight, params Type[] allowableClasses)
        {
            foreach (Type t in allowableClasses)
                AllowableClasses.Add(t);

            Name = name;
            Type = type;
            Price = price;
            Weight = weight;
            IsEquipped = false;
        }
        //Potion constructor
        protected BaseItem(string name, int amountBonus, Texture2D itemPic)
        {
            this.Name = name;
            this.AmountBonus = this.amountBonus;
            this.ItemPic = this.itemPic;
        }

        #endregion

        #region Property Region

        public List<Type> AllowableClasses
        {
            get { return allowableClasses; }
            protected set { allowableClasses = value; }
        }

        public string Type
        {
            get { return type; }
            protected set { type = value; }
        }

        public string Name
        {
            get { return name; }
            protected set { name = value; }
        }

        public int Price
        {
            get { return price; }
            protected set { price = value; }
        }

        public float Weight
        {
            get { return weight; }
            protected set { weight = value; }
        }

        public bool IsEquipped
        {
            get { return equipped; }
            protected set { equipped = value; }
        }

        public Texture2D ItemPic
        {
            get { return this.itemPic; }
            set { this.itemPic = value; }
        }

        public int AmountBonus
        {
            get { return this.amountBonus; }
            set { this.amountBonus = value; }

        }

        #endregion


        #region Abstract Method

        public abstract object Clone();

        public virtual bool CanEquip(Type characterType)
        {
            return allowableClasses.Contains(characterType);
        }

        public override string ToString()
        {
            string itemString = "";

            itemString += Name + ", ";
            itemString += Type + ", ";
            itemString += Price.ToString() + ", ";
            itemString += Weight.ToString();

            return itemString;
        }

        #endregion
    }
}
