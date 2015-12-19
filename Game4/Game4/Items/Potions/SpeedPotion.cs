using Microsoft.Xna.Framework.Graphics;
using RPGGame.Players;
using System;

namespace RPGGame.Items.Potions
{
    public class SpeedPotion : Potion
    {
        #region Constructor 
        public SpeedPotion(string name, int amountBonus, Texture2D itemPic)
            : base(name, amountBonus, itemPic)
        {
            this.Name = "Potion of Swiftness";
            this.AmountBonus = amountBonus;

        }
        #endregion

        #region Methods
        public override object Clone()
        {
            throw new NotImplementedException();
        }

        public override void DrinkPotion(Character player)
        {
            player.Speed += AmountBonus;
        }
        #endregion
    }
}