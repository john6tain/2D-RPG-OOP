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
		private int caffeine;
      
        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public Programmer(int x, int y) : base(x, y)
        {
            
        }
        public Programmer(int x, int y, Texture2D pic, double life, Ability hackingDors, int energy)
           : base(x, y, pic,life,hackingDors)
        {
            this.caffeine = 100;
        }
        #endregion

        #region Fields
        /// <summary>
        /// Fields
        /// </summary>
        public int Caffeine
        {
            get { return this.caffeine; }
            set{ this.caffeine = value;}
        }

        #endregion
    }
}