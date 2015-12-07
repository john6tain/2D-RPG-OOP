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
        private int energy;

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public Alexsination(int x, int y) 
			: base(x, y)
        {
            
        }
        public Alexsination(int x, int y, Texture2D pic, double life, Ability teleport, int energy)
           : base(x, y, pic, life, teleport)
        {
            this.Energy = 100;
        }
        #endregion



        #region Properties
        /// <summary>
        /// Properties
        /// </summary>
        public int Energy
        {
            get { return this.energy; }
            set
            {
                if (value > 100)
                {
                    value += 100;
                }
                this.energy = value;
            }
        }

        #endregion
    }
}