using Microsoft.Xna.Framework.Graphics;
using RPGGame.Players;

namespace RPGGame.Items.Potions
{
    public class FocusPotion : Potion
    {
        #region Constructor
        public FocusPotion(string name, int amountBonus, Texture2D itemPic)
            : base(name, amountBonus, itemPic)
        {
            this.Name = "Focus Potion";
            this.AmountBonus = 20;
        }
        #endregion

        #region Methods
        public override object Clone()
        {
            throw new System.NotImplementedException();
        }

        public override void DrinkPotion(Character player)
        {
            player.Focus += AmountBonus;
        }
        #endregion
    }
}