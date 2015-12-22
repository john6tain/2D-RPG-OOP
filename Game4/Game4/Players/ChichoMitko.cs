using Microsoft.Xna.Framework.Graphics;
using RPGGame.Players;

/// <summary>
/// Marto made this class
/// #ChichoMitko
/// #Focus
/// </summary>

namespace RPGGame.PlayersAndClasses
{
    public class ChichoMitko : Character
    {
        #region Constructor
        /// <summary>
        ///  Constructors
        /// </summary>

        public ChichoMitko(double x, double y)
            : base(x, y)
        {
        }

        public ChichoMitko(double x, double y, Texture2D pic, double life, Ability miracleShot, int damage, int speed, int focus)
            : base(x, y, pic, life, miracleShot, damage, speed)
        {
            this.Focus = 100;
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