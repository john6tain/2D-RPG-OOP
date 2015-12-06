using Game4.Players;
using Microsoft.Xna.Framework.Graphics;

/// <summary>
/// John made this class
/// #Programmer
/// #Caffeine
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
        public Programmer(int x, int y, Texture2D pic, double life, Ability hackingDoors, int caffeine)
           : base(x, y, pic, life, hackingDoors)
        {
            this.Caffeine = caffeine;
        }

        #endregion

        #region Properties
        /// <summary>
        /// Properties
        /// </summary>
        public int Caffeine
        {
            get { return this.caffeine; }
            set { this.caffeine = value; }
        }

        #endregion
    }
}