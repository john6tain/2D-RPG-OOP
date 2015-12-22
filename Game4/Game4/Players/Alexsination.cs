using Microsoft.Xna.Framework.Graphics;
using RPGGame.Players;

/// <summary>
/// Alex made this class
/// #Alexsination
/// #Energy
/// </summary>


namespace RPGGame.PlayersAndClasses
{
    public class Alexsination : Character
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>

        public Alexsination(double x, double y)
            : base(x, y)
        {
        }

        public Alexsination(double x, double y, Texture2D pic, double life, Ability shadowStep, int damage, int speed, int energy)
            : base(x, y, pic, life, shadowStep, damage, speed)
        {
            this.Energy = 100;
        }

        #endregion

        #region Action Methods

        public override void Attack(Character character)
        {
            throw new System.NotImplementedException();
        }

        public override void Defence(Character character)
        {
            throw new System.NotImplementedException();
        }
        #endregion

    }
}