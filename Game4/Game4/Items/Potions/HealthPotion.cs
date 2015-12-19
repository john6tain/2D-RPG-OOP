using Microsoft.Xna.Framework.Graphics;
using RPGGame.Players;

namespace RPGGame.Items.Potions
{
    public class HealthPotion : Potion
    {
        #region Constructor
        public HealthPotion(string name, int amountBonus, Texture2D itemPic)
            : base(name, amountBonus, itemPic)
        {
            this.Name = "Health Potion";
            this.AmountBonus = 100;
        }
        #endregion

        #region
        public override object Clone()
        {
            throw new System.NotImplementedException();
        }

        public override void DrinkPotion(Character player)
        {
            player.Life += AmountBonus;
        }
        #endregion
    }
}