using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPGGame.Enums;

namespace RPGGame.Items.ArmorMain
{
    public class Armor : BaseItem
    {
        #region Field Region

        ArmorSlot slot;
        int defenseValue;
        int defenseModifier;

        #endregion

        #region Property Region

        public ArmorSlot Slot
        {
            get { return slot; }
            protected set { slot = value; }
        }

        public int DefenseValue
        {
            get { return defenseValue; }
            protected set { defenseValue = value; }
        }

        public int DefenseModifier
        {
            get { return defenseModifier; }
            protected set { defenseModifier = value; }
        }

        #endregion

        #region Constructor Region

        public Armor(string armorName, string armorType, int price, float weight, ArmorSlot slot, int defenseValue, int defenseModifier, params Type[] allowableClasses)
            : base(armorName, armorType, price, weight, allowableClasses)
        {
            Slot = slot;
            DefenseValue = defenseValue;
            DefenseModifier = defenseModifier;
        }

        #endregion

        #region Abstract Method Region

        public override object Clone()
        {
            Type[] allowedClasses = new Type[allowableClasses.Count];

            for (int i = 0; i < allowableClasses.Count; i++)
            {
                allowedClasses[i] = allowableClasses[i];
            }

            Armor armor = new Armor(
                Name,
                Type,
                Price,
                Weight,
                Slot,
                DefenseValue,
                DefenseModifier,
                allowedClasses);

            return armor;
        }

        public override string ToString()
        {
            string armorString = base.ToString() + ", ";
            armorString += Slot.ToString() + ", ";
            armorString += DefenseValue.ToString() + ", ";
            armorString += DefenseModifier.ToString();

            foreach (Type t in allowableClasses)
                armorString += ", " + t.Name;

            return armorString;
        }

        #endregion 
    }
}
