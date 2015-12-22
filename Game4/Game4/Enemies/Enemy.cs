using Microsoft.Xna.Framework.Graphics;
using RPGGame.Players;

namespace RPGGame.Enemies
{
    public abstract class Enemy : Character
    {

        #region Constructors

        protected Enemy(double x, double y)
            : base(x, y)
        {
            
        }

        protected Enemy(double x, double y, Texture2D[] pics, double life, Ability myAbility, int damage, int speed)
            : base(x, y, pics, life, myAbility = null, damage, speed)
        {
            this.Life = 500;
        }

        #endregion

    }
}
