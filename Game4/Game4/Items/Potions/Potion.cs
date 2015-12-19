using Microsoft.Xna.Framework.Graphics;
using RPGGame.Interfaces;
using RPGGame.Players;

namespace RPGGame.Items.Potions
{

    public abstract class Potion : BaseItem, IPotion, IDrinkable

    {
        //Constructor
        #region Constructor
        protected Potion(string name, int amountBonus, Texture2D itemPic)
            : base(name, amountBonus, itemPic)
        {
        }
        #endregion

        //Property
        public Texture2D ItemPic { get; }

        //Method
        public abstract void DrinkPotion(Character player);


    }
}
