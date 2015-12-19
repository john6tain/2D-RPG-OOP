using Microsoft.Xna.Framework.Graphics;
using RPGGame.Players;

namespace RPGGame.Items.Potions
{
    public class DamagePotion : Potion
    {
        #region Constructor
        public DamagePotion(string name, int amountBonus, Texture2D itemPic)
            : base(name, amountBonus, itemPic)
        {
            this.Name = "Damage Potion";
            this.AmountBonus = amountBonus;
        }
        #endregion

        #region Methods
        public override object Clone()
        {
            throw new System.NotImplementedException();
        }

        public override void DrinkPotion(Character player)
        {
            player.Damage += AmountBonus;

        }
        #endregion
    }
}
