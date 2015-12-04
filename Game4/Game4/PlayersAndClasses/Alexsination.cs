using Game4.Players;
using Microsoft.Xna.Framework.Graphics;

/// <summary>
/// Alex made this class
/// #Alexsination
/// #Energy
/// </summary>


namespace Game4.PlayersAndClasses
{
    public class Alexsination : Player
    {
        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public Alexsination(int x, int y) : base(x, y)
        {
            
        }
        public Alexsination(int x, int y, Texture2D[] pics, double life, Ability teleport, int energy)
           : base(x, y, pics,1200, teleport)
        {
            this.Energy = 100;
        }
        #endregion

        #region Fields
        /// <summary>
        /// Fields
        /// </summary>
        public int Energy
        {
            get { return this.Energy; }
            set
            {
                if (value > 100)
                {
                    value += 100;
                }
                this.Energy = value;
            }
        }

        #endregion
    }
}