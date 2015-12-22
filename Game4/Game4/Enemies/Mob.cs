using Microsoft.Xna.Framework.Graphics;
using RPGGame.Players;

namespace RPGGame.Enemies
{
    public class Mob : Enemy
    {

        #region Constructor

        public Mob(double x, double y)
            : base(x, y)
        {
            this.Life = 200;
            this.Damage = 1;
        }

        public Mob(double x, double y, Texture2D[] pics, double life, Ability myAbility, int damage, int speed)
            : base(x, y, pics, life, myAbility, damage, speed)
        {
        }
        #endregion


    }
}
