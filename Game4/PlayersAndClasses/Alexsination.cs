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
        public Alexsination(int x, int y, Texture2D pic, double life, Ability teleport, int energy)
           : base(x, y)
        {
            this.Pic = pic;
            this.Life = 1200;
            this.Teleport = teleport;
            this.Energy = 100;
        }
        #endregion

        #region Fields
        /// <summary>
        /// Fields
        /// </summary>
        public Texture2D Pic
        {
            get { return this.Pic; }
            set { this.Pic = value; }
        }

        public double Life
        {
            get { return this.life; }
            set { this.life = value; }
        }

        public Ability Teleport
        {
            get { return this.Teleport; }
            set { this.Teleport = value; }
        }

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