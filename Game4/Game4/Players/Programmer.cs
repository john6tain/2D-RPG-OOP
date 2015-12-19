using Microsoft.Xna.Framework.Graphics;
using RPGGame.Players;

/// <summary>
/// John made this class
/// #Programmer
/// #Coffeine
/// </summary>


namespace RPGGame.PlayersAndClasses
{
    public class Programmer : Player
    {
        #region Fields
        /// <summary>
        /// Fields
        /// </summary>
        private int coffeine;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public Programmer(int x, int y) : base(x, y)
        {

        }
        public Programmer(int x, int y, Texture2D pic, double life, Ability hackingDoors, int coffeine, int damage, int speed)
           : base(x, y, pic, life, hackingDoors, damage, speed)
        {
            this.Coffeine = coffeine;
            this.Speed = 65;
        }

        #endregion

        #region Properties
        /// <summary>
        /// Properties
        /// </summary>
        public int Caffeine
        {
            get { return this.coffeine; }
            set { this.coffeine = value; }
        }

        #endregion

        #region Method

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