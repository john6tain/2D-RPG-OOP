using Microsoft.Xna.Framework.Graphics;
using RPGGame.Players;

namespace RPGGame.Enemies
{
    public class Boss : Enemy
    {

        #region Constructor

        public Boss(double x, double y)
            : base(x, y)
        {
            this.Life = 500;
            this.Damage = 3;
        }

        public Boss(double x, double y, Texture2D[] pics, double life, Ability myAbility, int damage, int speed)
            : base(x, y, pics, life, myAbility, damage, speed)
        {
        }
        #endregion

    }
}
