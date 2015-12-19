using Microsoft.Xna.Framework.Graphics;

namespace RPGGame.Interfaces
{
    public interface IPotion : IDrinkable
    {
        #region Only GET properties

        Texture2D ItemPic { get; }
        string Name { get; }
        int AmountBonus { get; }

        #endregion
    }
}
