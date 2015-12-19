using Microsoft.Xna.Framework.Graphics;
using RPGGame.Players;

/// <summary>
/// Alex made this class
/// #Alexsination
/// #Energy
/// </summary>


namespace RPGGame.PlayersAndClasses
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
        public Alexsination(int x, int y, Texture2D pic, double life, Ability teleport, int energy, int damage, int speed)
           : base(x, y, pic, life, teleport, damage, speed)
        {
            this.Energy = 100;
            this.Speed = 80;
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