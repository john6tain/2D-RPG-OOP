using Microsoft.Xna.Framework.Graphics;
using RPGGame.Players;

/// <summary>
/// Marto made this class
/// #ChichoMitko
/// #Focus
/// </summary>

namespace RPGGame.PlayersAndClasses
{
    public class ChichoMitko : Player
    {
        #region Fields
        /// <summary>
        /// Fields
        /// </summary>
        private int focus;

        #endregion

        #region Constructor
        /// <summary>
        ///  Constructors
        /// </summary>

        public ChichoMitko(int x, int y)
            : base(x, y)
        {

        }

        public ChichoMitko(int x, int y, Texture2D pic, double life, Ability miracleShot, int focus, int damage, int speed)
            : base(x, y, pic, life, miracleShot, damage, speed)
        {
            this.Focus = 100;
            this.Speed = 75;
        }

        #endregion

        #region Properties
        /// <summary>
        /// Properties
        /// </summary>
        public int Focus
        {
            get { return this.focus; }
            set
            {
                if (value > 100)
                {
                    value += 100;
                }
                this.focus = value;
            }
        }

        #endregion

        #region Methods Region

        public override void Attack(Character character)
        {
            throw new System.NotImplementedException();
        }

        public override void Defense(Character character)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}