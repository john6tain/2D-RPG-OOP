using Game4.Players;
using Microsoft.Xna.Framework.Graphics;

/// <summary>
/// Marto made this class
/// #ChichoMitko
/// #Focus
/// </summary>

namespace Game4.PlayersAndClasses
{
    public class ChichoMitko : Player
    {
        #region fields
        /// <summary>
        /// Fields
        /// </summary>
        private int focus;

        #endregion

        #region Constructor
        /// <summary>
        ///  Constructors
        /// </summary>

        public ChichoMitko(int x, int y) : base(x, y)
        {

        }

        public ChichoMitko(int x, int y, Texture2D pic, double life, Ability miracleShot, int focus)
           : base(x, y, pic, life, miracleShot)
        {
            this.Focus = 100;
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
    }
}
