using Game4.Players;
using Microsoft.Win32;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game4
{
    public class Player
    {
        #region Fields
        /// <summary>
        /// FIELDS
        /// </summary>
        private int x;
        private int y;
        private Texture2D pic;
        protected double life;
        protected Ability myAbility;

        #endregion

        #region Properties
        /// <summary>
        /// Properties
        /// </summary>
        public Texture2D Pic
        {
            get { return this.pic; }
            set { this.pic = value; }
        }
        public double Life
        {
            get { return this.x; }

            set
            {
                this.life = value;
            }
        }
        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Player(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.Life = 1000;
        }

        #region Moving Method
        /// <summary>
        /// Method Moving
        /// </summary>
        /// <param name="playerIndex"></param>
        /// <param name="keyses"></param>
        public void Moving(PlayerIndex playerIndex, Keys[] keyses)
        {
            if (Keyboard.GetState(playerIndex).IsKeyDown(keyses[0]))//left
            {
                x -= 10;
            }
            if (Keyboard.GetState(playerIndex).IsKeyDown(keyses[1]))//right
            {
                x += 10;
            }
            if (Keyboard.GetState(playerIndex).IsKeyDown(keyses[2]))//up
            {
                y -= 10;
            }
            if (Keyboard.GetState(playerIndex).IsKeyDown(keyses[3]))//down
            {
                y += 10;
            }
        }
        #endregion
    }


}
