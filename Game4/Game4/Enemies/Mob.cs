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
        }

        public Mob(double x, double y, Texture2D pic, double life, Ability myAbility, int damage, int speed)
            : base(x, y, pic, life, myAbility, damage, speed)
        {
        }
        #endregion

        #region Action Methods

        public override void Attack(Character character)
        {
            throw new System.NotImplementedException();
        }

        public override void Defence(Character character)
        {
            throw new System.NotImplementedException();
        }

        #endregion

    }
}
