using Game4.Players;
using Microsoft.Xna.Framework.Graphics;

/// <summary>
/// John made this class
/// #Programmer
/// #
/// </summary>


namespace Game4.PlayersAndClasses
{
    public class Programmer : Player
    {
        #region Fields
        /// <summary>
        /// Fields
        /// </summary>
        private int caffeine;
        #endregion
        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public Programmer(int x, int y) : base(x, y)
        {
            
        }
        public Programmer(int x, int y, Texture2D[] pics, double life, Ability hackingDors, int caffeine)
           : base(x, y, pics,life,hackingDors)
        {
            this.Caffeine = caffeine;
        }
        #endregion

        #region Fields
        /// <summary>
        /// Proparties
        /// </summary>
        public int Caffeine
        {
            get { return this.caffeine; }
            set{ this.caffeine = value;}
        }

        #endregion
    }
}